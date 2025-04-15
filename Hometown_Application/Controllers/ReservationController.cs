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
using Microsoft.AspNetCore.Authorization;

namespace Hometown_Application.Controllers
{
    public class ReservationController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public ReservationController(ApplicationDBContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Reservation/AvailableFacilities
        [Authorize]
        public async Task<IActionResult> AvailableFacilities()
        {
            var facilities = await _context.Facility
                .Where(f => !f.IsDeleted)
                .ToListAsync();

            Console.WriteLine($"Found {facilities.Count} facilities (IsDeleted = false)");
            foreach (var facility in facilities)
            {
                Console.WriteLine($"- {facility.Name}: IsAvailable = {facility.IsAvailable}, IsDeleted = {facility.IsDeleted}");
            }

            var facilityViewModels = new List<FacilityViewModel>();
            foreach (var facility in facilities)
            {
                var hasActiveReservations = await _context.Reservation
                    .AnyAsync(r => r.FacilityId == facility.FacilityId && !r.IsDeleted);

                // We no longer modify IsAvailable based on active reservations
                facilityViewModels.Add(new FacilityViewModel
                {
                    Facility = facility,
                    HasActiveReservations = hasActiveReservations
                });
            }

            return View(facilityViewModels);
        }

        // GET: Reservation/CreateOrEdit
        [Authorize]
        public async Task<IActionResult> CreateOrEdit(int? id, int? facilityId)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }

            var facilities = await _context.Facility
                .Where(f => !f.IsDeleted)
                .Select(f => new { f.FacilityId, f.Name })
                .ToListAsync();
            ViewBag.Facilities = facilities.Select(f => new { Value = f.FacilityId.ToString(), Text = f.Name });

            // Pass the time slots to the view
            ViewBag.TimeSlots = TimeSlot.AvailableTimeSlots.Select((slot, index) => new
            {
                Index = index,
                DisplayText = slot.DisplayText
            }).ToList();

            // Pass the UserId to the view
            ViewBag.UserId = user.Id;

            ReservationModel model;
            if (id == null) // Create new reservation
            {
                model = new ReservationModel
                {
                    FacilityId = facilityId ?? 0,
                    UserId = user.Id
                };
            }
            else // Edit existing reservation
            {
                model = await _context.Reservation
                    .Include(r => r.Facility)
                    .FirstOrDefaultAsync(r => r.ReservationId == id && !r.IsDeleted);
                if (model == null)
                {
                    return NotFound();
                }

                // Find the matching time slot index for editing
                var matchingSlotIndex = TimeSlot.AvailableTimeSlots.FindIndex(slot =>
                    slot.StartTime == model.StartTime.TimeOfDay &&
                    slot.EndTime == model.EndTime.TimeOfDay);
                model.SelectedTimeSlotIndex = matchingSlotIndex >= 0 ? matchingSlotIndex : 0;
            }

            return View(model);
        }

        // POST: Reservation/CreateOrEdit
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> CreateOrEdit(ReservationModel reservation)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }

            // Remove system-managed fields from ModelState validation
            ModelState.Remove("AddedBy");
            ModelState.Remove("AddedOn");
            ModelState.Remove("UpdatedBy");
            ModelState.Remove("UpdatedOn");
            ModelState.Remove("Facility");
            ModelState.Remove("ApplicationUser");
            ModelState.Remove("StartTime");
            ModelState.Remove("EndTime");

            if (ModelState.IsValid)
            {
                // Validate the selected time slot
                if (reservation.SelectedTimeSlotIndex < 0 || reservation.SelectedTimeSlotIndex >= TimeSlot.AvailableTimeSlots.Count)
                {
                    ModelState.AddModelError("SelectedTimeSlotIndex", "Please select a valid time slot.");
                    await PopulateViewBagFacilities();
                    ViewBag.TimeSlots = TimeSlot.AvailableTimeSlots.Select((slot, index) => new
                    {
                        Index = index,
                        DisplayText = slot.DisplayText
                    }).ToList();
                    ViewBag.UserId = user.Id;
                    return View(reservation);
                }

                // Set StartTime and EndTime based on the selected time slot
                var selectedTimeSlot = TimeSlot.AvailableTimeSlots[reservation.SelectedTimeSlotIndex];
                reservation.StartTime = reservation.ReservationDate.Date.Add(selectedTimeSlot.StartTime);
                reservation.EndTime = reservation.ReservationDate.Date.Add(selectedTimeSlot.EndTime);

                // Validate date and time
                var reservationDateTime = reservation.ReservationDate.Date.Add(reservation.StartTime.TimeOfDay);
                var reservationEndDateTime = reservation.ReservationDate.Date.Add(reservation.EndTime.TimeOfDay);

                if (reservationEndDateTime <= reservationDateTime)
                {
                    ModelState.AddModelError("EndTime", "End time must be later than start time.");
                    await PopulateViewBagFacilities();
                    ViewBag.TimeSlots = TimeSlot.AvailableTimeSlots.Select((slot, index) => new
                    {
                        Index = index,
                        DisplayText = slot.DisplayText
                    }).ToList();
                    ViewBag.UserId = user.Id;
                    return View(reservation);
                }

                // Check for overlapping reservations
                var overlappingReservations = await _context.Reservation
                    .Where(r => r.FacilityId == reservation.FacilityId
                        && !r.IsDeleted
                        && r.ReservationId != reservation.ReservationId
                        && r.ReservationDate.Date == reservation.ReservationDate.Date
                        && ((r.StartTime.TimeOfDay <= reservation.StartTime.TimeOfDay && r.EndTime.TimeOfDay > reservation.StartTime.TimeOfDay)
                            || (r.StartTime.TimeOfDay < reservation.EndTime.TimeOfDay && r.EndTime.TimeOfDay >= reservation.EndTime.TimeOfDay)
                            || (r.StartTime.TimeOfDay >= reservation.StartTime.TimeOfDay && r.EndTime.TimeOfDay <= reservation.EndTime.TimeOfDay)))
                    .AnyAsync();

                if (overlappingReservations)
                {
                    ModelState.AddModelError("", "The selected time slot is already reserved for this facility.");
                    await PopulateViewBagFacilities();
                    ViewBag.TimeSlots = TimeSlot.AvailableTimeSlots.Select((slot, index) => new
                    {
                        Index = index,
                        DisplayText = slot.DisplayText
                    }).ToList();
                    ViewBag.UserId = user.Id;
                    return View(reservation);
                }

                if (reservation.ReservationId == 0) // Create new reservation
                {
                    reservation.UserId = user.Id;
                    reservation.AddedBy = user.Id;
                    reservation.AddedOn = DateTime.UtcNow;
                    reservation.IsDeleted = false;

                    Console.WriteLine($"Creating new reservation: FacilityId: {reservation.FacilityId}, Date: {reservation.ReservationDate}, StartTime: {reservation.StartTime}, EndTime: {reservation.EndTime}, Status: {reservation.Status ?? "null"}, UserId: {reservation.UserId}");

                    _context.Reservation.Add(reservation);
                }
                else // Edit existing reservation
                {
                    var existingReservation = await _context.Reservation.FindAsync(reservation.ReservationId);
                    if (existingReservation == null)
                    {
                        return NotFound();
                    }

                    Console.WriteLine($"Before Update: ReservationId: {existingReservation.ReservationId}, FacilityId: {existingReservation.FacilityId}, Status: {existingReservation.Status ?? "null"}");

                    existingReservation.FacilityId = reservation.FacilityId;
                    existingReservation.ReservationDate = reservation.ReservationDate;
                    existingReservation.StartTime = reservation.StartTime;
                    existingReservation.EndTime = reservation.EndTime;
                    existingReservation.Status = reservation.Status;
                    existingReservation.UpdatedBy = user.Id;
                    existingReservation.UpdatedOn = DateTime.UtcNow;

                    Console.WriteLine($"After Update (Before Save): ReservationId: {existingReservation.ReservationId}, FacilityId: {existingReservation.FacilityId}, Status: {existingReservation.Status ?? "null"}");

                    _context.Update(existingReservation);
                }

                await _context.SaveChangesAsync();

                var savedReservation = await _context.Reservation.FindAsync(reservation.ReservationId);
                if (savedReservation != null)
                {
                    Console.WriteLine($"After Save (Database): ReservationId: {savedReservation.ReservationId}, FacilityId: {savedReservation.FacilityId}, Status: {savedReservation.Status ?? "null"}, IsDeleted: {savedReservation.IsDeleted}");
                }

                return RedirectToAction("ReservationStatusReport");
            }

            // Debug: Log validation errors
            foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
            {
                Console.WriteLine($"Validation Error: {error.ErrorMessage}");
            }

            await PopulateViewBagFacilities();
            ViewBag.TimeSlots = TimeSlot.AvailableTimeSlots.Select((slot, index) => new
            {
                Index = index,
                DisplayText = slot.DisplayText
            }).ToList();
            ViewBag.UserId = user.Id;
            return View(reservation);
        }

        // GET: Reservation/ReservationStatusReport
        [Authorize]
        public async Task<IActionResult> ReservationStatusReport()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }

            var reservations = await _context.Reservation
                .Include(r => r.Facility)
                .Where(r => r.UserId == user.Id && !r.IsDeleted)
                .ToListAsync();

            Console.WriteLine($"Retrieved {reservations.Count} reservations for user {user.Id}");
            foreach (var reservation in reservations)
            {
                Console.WriteLine($"ReservationId: {reservation.ReservationId}, Facility: {reservation.Facility?.Name ?? "N/A"}, Date: {reservation.ReservationDate}, Status: {reservation.Status ?? "null"}");
            }

            return View(reservations);
        }

        // API: Check if a time slot is available
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> CheckTimeSlotAvailability(int facilityId, string reservationDate, int timeSlotIndex)
        {
            // Validate inputs
            if (facilityId <= 0 || string.IsNullOrEmpty(reservationDate) || timeSlotIndex < 0 || timeSlotIndex >= TimeSlot.AvailableTimeSlots.Count)
            {
                return Json(new { isAvailable = false, message = "Invalid input parameters." });
            }

            // Parse the reservation date
            if (!DateTime.TryParse(reservationDate, out var parsedDate))
            {
                return Json(new { isAvailable = false, message = "Invalid reservation date format." });
            }

            // Get the selected time slot
            var selectedTimeSlot = TimeSlot.AvailableTimeSlots[timeSlotIndex];
            var startTime = parsedDate.Date.Add(selectedTimeSlot.StartTime);
            var endTime = parsedDate.Date.Add(selectedTimeSlot.EndTime);

            // Check for existing reservations
            var hasReservation = await _context.Reservation
                .Where(r => r.FacilityId == facilityId
                    && !r.IsDeleted
                    && r.ReservationDate.Date == parsedDate.Date
                    && ((r.StartTime.TimeOfDay <= startTime.TimeOfDay && r.EndTime.TimeOfDay > startTime.TimeOfDay)
                        || (r.StartTime.TimeOfDay < endTime.TimeOfDay && r.EndTime.TimeOfDay >= endTime.TimeOfDay)
                        || (r.StartTime.TimeOfDay >= startTime.TimeOfDay && r.EndTime.TimeOfDay <= endTime.TimeOfDay)))
                .AnyAsync();

            if (hasReservation)
            {
                return Json(new { isAvailable = false, message = $"The time slot {selectedTimeSlot.DisplayText} is already reserved for this facility on {parsedDate.ToString("yyyy-MM-dd")}." });
            }

            return Json(new { isAvailable = true, message = "The time slot is available." });
        }

        private async Task PopulateViewBagFacilities()
        {
            var facilities = await _context.Facility
                .Where(f => !f.IsDeleted)
                .Select(f => new { f.FacilityId, f.Name })
                .ToListAsync();
            ViewBag.Facilities = facilities.Select(f => new { Value = f.FacilityId.ToString(), Text = f.Name });

            Console.WriteLine($"Loaded {facilities.Count} facilities into ViewBag");
            foreach (var facility in facilities)
            {
                Console.WriteLine($"FacilityId: {facility.FacilityId}, Name: {facility.Name}");
            }
        }
    }
}