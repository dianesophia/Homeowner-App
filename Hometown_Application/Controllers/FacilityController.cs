using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Hometown_Application.Areas.Identity.Data;
using Hometown_Application.Data;
using Hometown_Application.Models;
using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace Hometown_Application.Controllers
{
    public class FacilityController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public FacilityController(ApplicationDBContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Facility/Index
        public async Task<IActionResult> Index()
        {
            return View(await _context.Facility.Where(f => !f.IsDeleted).ToListAsync());
        }

        // GET: Facility/CreateOrEditFacility
        [Authorize]
        public async Task<IActionResult> CreateOrEditFacility(int? id)
        {
            if (id == null)
            {
                return View(new FacilityModel()); // Create new facility
            }

            var facility = await _context.Facility.FindAsync(id);
            if (facility == null)
            {
                return NotFound();
            }

            return View(facility); // Edit existing facility
        }

        // POST: Facility/CreateOrEditFacility
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> CreateOrEditFacility(FacilityModel facility, IFormFile file)
        {
            var user = await _userManager.GetUserAsync(User);

            // Remove system-managed fields from ModelState validation
            ModelState.Remove("AddedBy");
            ModelState.Remove("AddedOn");
            ModelState.Remove("UpdatedBy");
            ModelState.Remove("UpdatedOn");
            ModelState.Remove("Image");

            if (ModelState.IsValid && user != null)
            {
                if (facility.FacilityId == 0) // Create new facility
                {
                    facility.AddedBy = user.Id;
                    facility.AddedOn = DateTime.UtcNow;
                    facility.IsDeleted = false;

                    Console.WriteLine($"Creating new facility: Name: {facility.Name}, IsAvailable: {facility.IsAvailable}, IsDeleted: {facility.IsDeleted}, File Uploaded: {(file != null ? file.FileName : "None")}");

                    if (file != null && file.Length > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            await file.CopyToAsync(memoryStream);
                            facility.Image = memoryStream.ToArray();
                        }
                    }

                    _context.Facility.Add(facility);
                }
                else // Edit existing facility
                {
                    var existingFacility = await _context.Facility.FindAsync(facility.FacilityId);
                    if (existingFacility == null)
                    {
                        return NotFound();
                    }

                    Console.WriteLine($"Before Update: Facility: {existingFacility.Name}, IsAvailable: {existingFacility.IsAvailable}, IsDeleted: {existingFacility.IsDeleted}");

                    existingFacility.Name = facility.Name;
                    existingFacility.Type = facility.Type;
                    existingFacility.Capacity = facility.Capacity;
                    existingFacility.Description = facility.Description;
                    existingFacility.IsAvailable = facility.IsAvailable; // Use the manually set value
                    existingFacility.UpdatedBy = user.Id;
                    existingFacility.UpdatedOn = DateTime.UtcNow;

                    Console.WriteLine($"After Update (Before Save): Facility: {existingFacility.Name}, IsAvailable: {existingFacility.IsAvailable}, IsDeleted: {existingFacility.IsDeleted}, File Uploaded: {(file != null ? file.FileName : "None")}");

                    if (file != null && file.Length > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            await file.CopyToAsync(memoryStream);
                            existingFacility.Image = memoryStream.ToArray();
                        }
                    }
                    else
                    {
                        var originalFacility = await _context.Facility.AsNoTracking().FirstOrDefaultAsync(f => f.FacilityId == facility.FacilityId);
                        if (originalFacility != null)
                        {
                            existingFacility.Image = originalFacility.Image;
                        }
                    }

                    _context.Update(existingFacility);
                }

                await _context.SaveChangesAsync();

                var savedFacility = await _context.Facility.FindAsync(facility.FacilityId);
                if (savedFacility != null)
                {
                    Console.WriteLine($"After Save (Database): Facility: {savedFacility.Name}, IsAvailable: {savedFacility.IsAvailable}, IsDeleted: {savedFacility.IsDeleted}");
                }

                return RedirectToAction("AvailableFacilities", "Reservation");
            }

            foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
            {
                Console.WriteLine($"Validation Error: {error.ErrorMessage}");
            }

            return View(facility);
        }

        // GET: Facility/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var facility = await _context.Facility.FindAsync(id);
            if (facility == null)
            {
                return NotFound();
            }

            return View(facility);
        }

        // POST: Facility/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var facility = await _context.Facility.FindAsync(id);
            if (facility != null)
            {
                facility.IsDeleted = true;
                _context.Update(facility);
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = "Facility has been soft deleted and can be restored by an admin.";
            }
            else
            {
                TempData["ErrorMessage"] = "Facility not found.";
            }

            return RedirectToAction(nameof(Index));
        }
    }
}