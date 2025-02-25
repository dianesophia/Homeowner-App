using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Hometown_Application.Data;
using Hometown_Application.Models;

public class FacilityController : Controller
{
    private readonly ApplicationDBContext _context;

    public FacilityController(ApplicationDBContext context)
    {
        _context = context;
    }

    // GET: Facility/Index
    public async Task<IActionResult> Index()
    {
        return View(await _context.Facility.ToListAsync());
    }

    // GET: Facility/CreateOrEditFacility
    public IActionResult CreateOrEditFacility(int? id)
    {
        if (id == null)
        {
            return View(new FacilityModel()); // Create a new facility
        }

        var facility = _context.Facility.Find(id);
        if (facility == null)
        {
            return NotFound();
        }

        return View(facility); // Edit existing facility
    }

    // POST: Facility/CreateOrEditFacility
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> CreateOrEditFacility(FacilityModel facility, IFormFile file) // Match the view's file input name
    {
        if (ModelState.IsValid)
        {
            if (facility.Id == 0) // Create new facility
            {
                if (file != null && file.Length > 0)
                {
                    var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads", fileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }

                    facility.ImagePath = "/uploads/" + fileName;
                }

                _context.Facility.Add(facility);
            }
            else // Edit existing facility
            {
                var existingFacility = await _context.Facility.FindAsync(facility.Id);
                if (existingFacility == null)
                {
                    return NotFound();
                }

                existingFacility.Name = facility.Name;
                existingFacility.Type = facility.Type;
                existingFacility.Capacity = facility.Capacity;
                existingFacility.Description = facility.Description;

                if (file != null && file.Length > 0)
                {
                    var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads", fileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }

                    // Delete old image if exists
                    if (!string.IsNullOrEmpty(existingFacility.ImagePath))
                    {
                        var oldImagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", existingFacility.ImagePath.TrimStart('/'));
                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }

                    existingFacility.ImagePath = "/uploads/" + fileName;
                }

                _context.Update(existingFacility);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        return View(facility);
    }

    // GET: Facility/Delete/5
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
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var facility = await _context.Facility.FindAsync(id);
        if (facility != null)
        {
            if (!string.IsNullOrEmpty(facility.ImagePath))
            {
                var imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", facility.ImagePath.TrimStart('/'));
                if (System.IO.File.Exists(imagePath))
                {
                    System.IO.File.Delete(imagePath);
                }
            }

            _context.Facility.Remove(facility);
            await _context.SaveChangesAsync();
        }

        return RedirectToAction(nameof(Index));
    }
}