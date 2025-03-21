using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Hometown_Application.Areas.Identity.Data;
using Microsoft.AspNetCore.Authorization;
using Hometown_Application.Data;
using Hometown_Application.Models;
using System;
using System.Linq;
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
            _context.VehicleGatepasses.Add(model);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(int id)
        {
            Console.WriteLine($"Edit action reached with id: {id}");
            var vehicleGatePass = await _context.VehicleGatepasses
                .FirstOrDefaultAsync(v => v.VehicleId == id && !v.IsDeleted);

            if (vehicleGatePass == null)
            {
                return NotFound();
            }

            return View(vehicleGatePass);
        }



        // POST: VehicleGatePass/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, VehicleGatepassModel model)
        {
            if (id != model.VehicleId)
            {
                return NotFound();
            }

            var vehicleGatePass = await _context.VehicleGatepasses
                .FirstOrDefaultAsync(v => v.VehicleId == id && !v.IsDeleted);

            if (vehicleGatePass == null)
            {
                return NotFound();
            }

            try
            {
                vehicleGatePass.VehicleBrand = model.VehicleBrand;
                vehicleGatePass.VehicleColor = model.VehicleColor;
                vehicleGatePass.VehiclePlateNumber = model.VehiclePlateNumber;

                _context.Update(vehicleGatePass);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.VehicleGatepasses.Any(e => e.VehicleId == id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
        }

        // GET: VehicleGatePass/Index
        public async Task<IActionResult> Index()
        {
            var vehicleGatePasses = await _context.VehicleGatepasses
                .Where(v => !v.IsDeleted)
                .Include(v => v.ApplicationUser)
                .ToListAsync();

            return View(vehicleGatePasses);
        }

        // GET: VehicleGatePass/Delete/{id}
        public async Task<IActionResult> Delete(int id)
        {
            var vehicleGatePass = await _context.VehicleGatepasses
                .Include(v => v.ApplicationUser)
                .FirstOrDefaultAsync(v => v.VehicleId == id);

            if (vehicleGatePass == null)
            {
                return NotFound();
            }

            return View(vehicleGatePass);
        }

        // POST: VehicleGatePass/DeleteConfirmed/{id}
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vehicleGatePass = await _context.VehicleGatepasses.FindAsync(id);
            if (vehicleGatePass == null)
            {
                return NotFound();
            }

            vehicleGatePass.IsDeleted = true; // Soft delete
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
