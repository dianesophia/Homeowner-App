using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Linq;
using Hometown_Application.Data;
using Hometown_Application.Models;

public class ReservationController : Controller
{
    private readonly ApplicationDBContext _context;

    public ReservationController(ApplicationDBContext context)
    {
        _context = context;
    }

    // Display all reservations
    public async Task<IActionResult> Index()
    {
        var reservations = _context.Reservation
            .Include(r => r.Facility)
            .Where(r => !r.IsDeleted)
            .ToListAsync();
        return View(await reservations);
    }

    // Create reservation - GET
    public async Task<IActionResult> Create()
    {
        ViewBag.Facilities = new SelectList(await _context.Facility.Where(f => !f.IsDeleted).ToListAsync(), "Id", "Name");
        return View();
    }

    // Create reservation - POST
    [HttpPost]
    [Authorize]
    public async Task<IActionResult> Create(ReservationModel reservation)
    {
        if (ModelState.IsValid)
        {
            var facility = await _context.Facility.FindAsync(reservation.FacilityId);
            if (facility == null)
            {
                ModelState.AddModelError("", "Selected facility does not exist.");
                return View(reservation);
            }

            // Count active reservations for the selected facility
            int activeReservations = await _context.Reservation
                .Where(r => r.FacilityId == reservation.FacilityId && !r.IsDeleted)
                .CountAsync();

            if (activeReservations >= facility.Capacity)
            {
                ModelState.AddModelError("", "This facility has reached its reservation limit.");
                ViewBag.Facilities = new SelectList(await _context.Facility.Where(f => !f.IsDeleted).ToListAsync(), "Id", "Name");
                return View(reservation);
            }

            // Proceed with reservation
            reservation.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            reservation.Status = "Pending";
            _context.Reservation.Add(reservation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        ViewBag.Facilities = new SelectList(await _context.Facility.Where(f => !f.IsDeleted).ToListAsync(), "Id", "Name");
        return View(reservation);
    }

    // Delete Reservation
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> Delete(int id)
    {
        var reservation = await _context.Reservation.FindAsync(id);
        if (reservation == null)
        {
            return NotFound();
        }

        reservation.IsDeleted = true;
        _context.Reservation.Update(reservation);
        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }
}
