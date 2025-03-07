using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Hometown_Application.Areas.Identity.Data;
using Hometown_Application.Data;
using Hometown_Application.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Hometown_Application.Controllers
{
    [Authorize]
    public class ReservationController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<ReservationController> _logger;

        public ReservationController(ApplicationDBContext context, UserManager<ApplicationUser> userManager, ILogger<ReservationController> logger)
        {
            _context = context;
            _userManager = userManager;
            _logger = logger;
        }

        // User View: List Reservations for Current User
        [Authorize(Roles = "HomeOwner")]
        public async Task<IActionResult> ReservationStatusReport()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return View();

            var reservations = await _context.Reservation
                .Where(r => r.UserId == user.Id && !r.IsDeleted)
                .Include(r => r.Facility)
                .ToListAsync();

            return View(reservations);
        }

        public async Task<IActionResult> AvailableFacilities()
        {
            var facilities = await _context.Facility
                .Where(f => !f.IsDeleted)
                .ToListAsync();
            return View(facilities);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> UpdateReservationStatus(int id, string newStatus)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid reservation ID.");
            }

            var reservation = await _context.Reservation
                .FirstOrDefaultAsync(r => r.ReservationId == id && !r.IsDeleted);

            if (reservation == null)
            {
                return NotFound("Reservation not found.");
            }

            var validStatuses = new[] { "Pending", "Approved", "Declined" };
            if (string.IsNullOrEmpty(newStatus) || !validStatuses.Contains(newStatus))
            {
                return BadRequest("Invalid status value.");
            }

            try
            {
                reservation.Status = newStatus;
                reservation.UpdatedOn = DateTime.UtcNow;
                reservation.UpdatedBy = _userManager.GetUserId(User) ?? throw new InvalidOperationException("User ID not found.");

                await _context.SaveChangesAsync();

                _logger.LogInformation("Reservation {Id} status updated to {NewStatus}", id, newStatus);
                TempData["ActiveTab"] = newStatus;
                TempData["SuccessMessage"] = $"Reservation status updated to {newStatus} successfully.";

                // Preserve the original statusFilter or show all reservations
                var originalStatusFilter = Request.Query["statusFilter"].ToString() ?? "";
                return RedirectToAction("ManageReservations", new
                {
                    statusFilter = string.IsNullOrEmpty(originalStatusFilter) ? "" : originalStatusFilter,
                    search = Request.Query["search"].ToString(),
                    pageNumber = Request.Query["pageNumber"].ToString() ?? "1"
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating reservation status for ID: {Id}", id);
                ModelState.AddModelError("", $"An error occurred while updating the reservation status: {ex.Message}");
                return View("Error");
            }
        }

        // Admin View: Manage Reservations with Tabs
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ManageReservations(string search, string statusFilter, int pageNumber = 1, int pageSize = 10)
        {
            var query = _context.Reservation
                .Include(r => r.Facility)
                .Include(r => r.ApplicationUser)
                .Where(r => !r.IsDeleted)
                .AsQueryable();

            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(r => r.Facility != null && r.Facility.Name.Contains(search));
            }

            if (!string.IsNullOrEmpty(statusFilter))
            {
                query = query.Where(r => r.Status == statusFilter);
            }

            var totalReservations = await query.CountAsync();
            var reservations = await query
                .OrderBy(r => r.ReservationDate)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            var model = new ReservationListViewModel
            {
                Reservations = reservations,
                SearchQuery = search,
                StatusFilter = statusFilter,
                PageNumber = pageNumber,
                TotalPages = (int)Math.Ceiling((double)totalReservations / pageSize)
            };

            return View(model);
        }

        // Create/Edit Reservation (User Action)
        public async Task<IActionResult> CreateOrEdit(int? id, int? facilityId)
        {
            ViewBag.Facilities = new SelectList(await _context.Facility
                .Where(f => !f.IsDeleted)
                .ToListAsync(), "FacilityId", "Name");

            var user = await _userManager.GetUserAsync(User);
            if (id == null)
            {
                return View(new ReservationModel
                {
                    FacilityId = facilityId ?? 0,
                    UserId = user?.Id,
                    Status = "Pending"
                });
            }

            var reservation = await _context.Reservation
                .Include(r => r.Facility)
                .FirstOrDefaultAsync(r => r.ReservationId == id && !r.IsDeleted);

            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateOrEdit(ReservationModel reservation)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return Unauthorized();
            }

            // Decode RowVersion from Base64 if provided
            if (!string.IsNullOrEmpty(Request.Form["RowVersion"]))
            {
                reservation.RowVersion = Convert.FromBase64String(Request.Form["RowVersion"]);
            }

            if (!ModelState.IsValid)
            {
                ViewBag.Facilities = new SelectList(await _context.Facility
                    .Where(f => !f.IsDeleted)
                    .ToListAsync(), "FacilityId", "Name");
                return View(reservation);
            }

            // Check for time conflicts
            var hasConflict = await _context.Reservation
                .AnyAsync(r => r.FacilityId == reservation.FacilityId
                    && !r.IsDeleted
                    && r.ReservationId != reservation.ReservationId
                    && r.ReservationDate == reservation.ReservationDate
                    && ((r.StartTime < reservation.EndTime && r.EndTime > reservation.StartTime)));

            if (hasConflict)
            {
                ModelState.AddModelError("", "This time slot is already booked.");
                ViewBag.Facilities = new SelectList(await _context.Facility
                    .Where(f => !f.IsDeleted)
                    .ToListAsync(), "FacilityId", "Name");
                return View(reservation);
            }

            try
            {
                if (reservation.ReservationId == 0) // Create
                {
                    reservation.AddedBy = user.Id; // Ensure AddedBy is set
                    reservation.UserId = user.Id;
                    reservation.AddedOn = DateTime.UtcNow;
                    reservation.Status = "Pending";
                    reservation.RowVersion = null; // New records won’t have a RowVersion yet
                    _context.Reservation.Add(reservation);
                }
                else // Update
                {
                    var existing = await _context.Reservation
                        .FirstOrDefaultAsync(r => r.ReservationId == reservation.ReservationId && !r.IsDeleted);

                    if (existing == null)
                    {
                        return NotFound();
                    }

                    // Handle concurrency
                    if (existing.RowVersion != reservation.RowVersion)
                    {
                        ModelState.AddModelError("", "The reservation was modified by another user. Please refresh and try again.");
                        ViewBag.Facilities = new SelectList(await _context.Facility
                            .Where(f => !f.IsDeleted)
                            .ToListAsync(), "FacilityId", "Name");
                        return View(reservation);
                    }

                    existing.FacilityId = reservation.FacilityId;
                    existing.ReservationDate = reservation.ReservationDate;
                    existing.StartTime = reservation.StartTime;
                    existing.EndTime = reservation.EndTime;
                    existing.Status = reservation.Status;
                    existing.UpdatedBy = user.Id;
                    existing.UpdatedOn = DateTime.UtcNow;
                    existing.RowVersion = reservation.RowVersion; // Update RowVersion
                    _context.Update(existing);
                }

                await _context.SaveChangesAsync();
                return RedirectToAction("ReservationStatusReport");
            }
            catch (DbUpdateConcurrencyException)
            {
                ModelState.AddModelError("", "The reservation was modified by another user. Please refresh and try again.");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "An error occurred while saving the reservation.");
                // Log error here in production
            }

            ViewBag.Facilities = new SelectList(await _context.Facility
                .Where(f => !f.IsDeleted)
                .ToListAsync(), "FacilityId", "Name");
            return View(reservation);
        }
    }
}