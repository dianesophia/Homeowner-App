using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Hometown_Application.Areas.Identity.Data;
using Microsoft.AspNetCore.Authorization;
using Hometown_Application.Data;
using Hometown_Application.Models;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Hometown_Application.Controllers
{
    [Authorize]
    public class VehicleGatePassController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public VehicleGatePassController(ApplicationDBContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: VehicleGatePass/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VehicleGatePass/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(VehicleGatepassModel model)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return RedirectToAction("Index");

            model.UserId = user.Id;

            // Add the new VehicleGatePass entry
            _context.VehicleGatepasses.Add(model);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index"); // Redirect to the list view after successful creation
        }

        // GET: VehicleGatePass/Index
        public async Task<IActionResult> Index()
        {
            var vehicleGatePasses = await _context.VehicleGatepasses
                .Include(v => v.ApplicationUser) // Include the user data
                .ToListAsync();

            return View(vehicleGatePasses);
        }

        // GET: VehicleGatePass/Details/{id}
        public async Task<IActionResult> Details(int id)
        {
            var vehicleGatePass = await _context.VehicleGatepasses
                .Include(v => v.ApplicationUser) // Include the user data
                .FirstOrDefaultAsync(v => v.VehicleId == id);

            if (vehicleGatePass == null)
            {
                return NotFound();
            }

            return View(vehicleGatePass);
        }

        // GET: VehicleGatePass/Edit/{id}
        public async Task<IActionResult> Edit(int id)
        {
            var vehicleGatePass = await _context.VehicleGatepasses.FindAsync(id);
            if (vehicleGatePass == null)
            {
                return NotFound();
            }

            return View(vehicleGatePass);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, VehicleGatepassModel model)
        {
            if (id != model.VehicleId)
            {
                return NotFound();
            }

            try
            {
                _context.Entry(model).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VehicleGatepassModelExists(model.VehicleId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToAction(nameof(Index));
        }


        // GET: VehicleGatePass/Delete/{id}
        public async Task<IActionResult> Delete(int id)
        {
            var vehicleGatePass = await _context.VehicleGatepasses
                .Include(v => v.ApplicationUser) // Include the user data
                .FirstOrDefaultAsync(v => v.VehicleId == id);

            if (vehicleGatePass == null)
            {
                return NotFound();
            }

            return View(vehicleGatePass);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vehicleGatePass = await _context.VehicleGatepasses.FindAsync(id);
            if (vehicleGatePass == null)
            {
                return NotFound();
            }

            _context.VehicleGatepasses.Remove(vehicleGatePass);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        private bool VehicleGatepassModelExists(int id)
        {
            return _context.VehicleGatepasses.Any(e => e.VehicleId == id);
        }
    }
}
