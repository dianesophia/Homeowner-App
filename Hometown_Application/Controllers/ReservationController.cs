using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Hometown_Application.Areas.Identity.Data;
using Hometown_Application.Data;
using Hometown_Application.Models;
using System;
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

        public ReservationController(ApplicationDBContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
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

        // GET: Reservation/AvailableFacilities
        public async Task<IActionResult> AvailableFacilities()
        {
            // Get facilities that are not deleted
            var facilities = await _context.Facility
                .Where(f => !f.IsDeleted)
                .ToListAsync();

            // Debug: Log all facilities before filtering
            Console.WriteLine($"Before Filtering: Found {facilities.Count} facilities (IsDeleted = false)");
            foreach (var facility in facilities)
            {
                Console.WriteLine($"Facility: {facility.Name}, IsAvailable: {facility.IsAvailable}, IsDeleted: {facility.IsDeleted}");
            }

            // Create a list of FacilityViewModel objects
            var facilityViewModels = new List<FacilityViewModel>();
            foreach (var facility in facilities)
            {
                // Check if the facility has any active reservations
                var hasActiveReservations = await _context.Reservation
                    .AnyAsync(r => r.FacilityId == facility.FacilityId && !r.IsDeleted);

                // Only include facilities that are marked as available and have no active reservations
                if (facility.IsAvailable && !hasActiveReservations)
                {
                    facilityViewModels.Add(new FacilityViewModel
                    {
                        Facility = facility,
                        HasActiveReservations = hasActiveReservations
                    });
                }
                else
                {
                    // If the facility has active reservations but IsAvailable is true, correct the status
                    if (hasActiveReservations && facility.IsAvailable)
                    {
                        Console.WriteLine($"Correcting IsAvailable for {facility.Name}: Has active reservations, setting IsAvailable to false");
                        facility.IsAvailable = false;
                        _context.Update(facility);
                    }
                    else if (!facility.IsAvailable)
                    {
                        Console.WriteLine($"Excluding {facility.Name}: IsAvailable is false");
                    }
                }
            }

            await _context.SaveChangesAsync();

            // Debug: Log the facilities after filtering
            Console.WriteLine($"After Filtering: Found {facilityViewModels.Count} facilities");
            foreach (var vm in facilityViewModels)
            {
                Console.WriteLine($"Facility: {vm.Facility.Name}, IsAvailable: {vm.Facility.IsAvailable}, IsDeleted: {vm.Facility.IsDeleted}, HasActiveReservations: {vm.HasActiveReservations}");
            }

            return View(facilityViewModels);
        }

        // Create/Edit Reservation (User Action)
        public async Task<IActionResult> CreateOrEdit(int? id, int? facilityId)
        {
            ViewBag.Facilities = new SelectList(await _context.Facility
                .Where(f => !f.IsDeleted && f.IsAvailable)
                .ToListAsync(), "FacilityId", "Name");

            var user = await _userManager.GetUserAsync(User);
            if (id == null)
            {
                return View(new ReservationModel
                {
                    FacilityId = facilityId ?? 0,
                    UserId = user?.Id
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

            if (!ModelState.IsValid)
            {
                ViewBag.Facilities = new SelectList(await _context.Facility
                    .Where(f => !f.IsDeleted && f.IsAvailable)
                    .ToListAsync(), "FacilityId", "Name");
                return View(reservation);
            }

            // Check for time conflicts and facility availability
            var facility = await _context.Facility.FindAsync(reservation.FacilityId);
            if (facility == null || !facility.IsAvailable)
            {
                ModelState.AddModelError("", "Selected facility is not available.");
                ViewBag.Facilities = new SelectList(await _context.Facility
                    .Where(f => !f.IsDeleted && f.IsAvailable)
                    .ToListAsync(), "FacilityId", "Name");
                return View(reservation);
            }

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
                    .Where(f => !f.IsDeleted && f.IsAvailable)
                    .ToListAsync(), "FacilityId", "Name");
                return View(reservation);
            }

            try
            {
                if (reservation.ReservationId == 0) // Create
                {
                    reservation.AddedBy = user.Id;
                    reservation.UserId = user.Id;
                    reservation.AddedOn = DateTime.UtcNow;
                    _context.Reservation.Add(reservation);

                    // Mark facility as Not Available after successful reservation
                    facility.IsAvailable = false;
                    _context.Update(facility);
                }
                else // Update
                {
                    var existing = await _context.Reservation
                        .FirstOrDefaultAsync(r => r.ReservationId == reservation.ReservationId && !r.IsDeleted);

                    if (existing == null)
                    {
                        return NotFound();
                    }

                    // If the facility has changed, mark the old facility as available if no other reservations exist
                    if (existing.FacilityId != reservation.FacilityId)
                    {
                        var oldFacility = await _context.Facility.FindAsync(existing.FacilityId);
                        if (oldFacility != null)
                        {
                            var hasOtherReservations = await _context.Reservation
                                .AnyAsync(r => r.FacilityId == existing.FacilityId && !r.IsDeleted && r.ReservationId != existing.ReservationId);
                            if (!hasOtherReservations)
                            {
                                oldFacility.IsAvailable = true;
                                _context.Update(oldFacility);
                            }
                        }

                        // Mark the new facility as not available
                        facility.IsAvailable = false;
                        _context.Update(facility);
                    }

                    existing.FacilityId = reservation.FacilityId;
                    existing.ReservationDate = reservation.ReservationDate;
                    existing.StartTime = reservation.StartTime;
                    existing.EndTime = reservation.EndTime;
                    existing.UpdatedBy = user.Id;
                    existing.UpdatedOn = DateTime.UtcNow;
                    _context.Update(existing);
                }

                await _context.SaveChangesAsync();
                return RedirectToAction("ReservationStatusReport");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "An error occurred while saving the reservation: " + ex.Message);
            }

            ViewBag.Facilities = new SelectList(await _context.Facility
                .Where(f => !f.IsDeleted && f.IsAvailable)
                .ToListAsync(), "FacilityId", "Name");
            return View(reservation);
        }
        // GET: Reservation/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
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

        // POST: Reservation/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reservation = await _context.Reservation
                .Include(r => r.Facility)
                .FirstOrDefaultAsync(r => r.ReservationId == id);

            if (reservation != null)
            {
                reservation.IsDeleted = true;
                _context.Update(reservation);

                // Check if there are any other active reservations for this facility
                var hasActiveReservations = await _context.Reservation
                    .AnyAsync(r => r.FacilityId == reservation.FacilityId && !r.IsDeleted);

                if (!hasActiveReservations)
                {
                    // If no active reservations, mark the facility as available
                    var facility = await _context.Facility.FindAsync(reservation.FacilityId);
                    if (facility != null)
                    {
                        facility.IsAvailable = true;
                        _context.Update(facility);
                    }
                }

                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = "Reservation has been deleted, and the facility is now available if no other reservations exist.";
            }
            else
            {
                TempData["ErrorMessage"] = "Reservation not found.";
            }

            return RedirectToAction(nameof(ReservationStatusReport));
        }
    }
}