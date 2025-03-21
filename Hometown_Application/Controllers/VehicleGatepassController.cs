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
            model.AddedOn = DateTime.UtcNow;
            model.AddedBy = user.Id;
            _context.VehicleGatepasses.Add(model);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
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

        public async Task<IActionResult> Edit(int id)
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
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, VehicleGatepassModel model)
        {
            var vehicleGatePass = await _context.VehicleGatepasses.FindAsync(id);
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return RedirectToAction("Index");
            if (vehicleGatePass == null)
            {
                return NotFound();
            }

            vehicleGatePass.VehicleBrand = model.VehicleBrand;
            vehicleGatePass.VehicleColor = model.VehicleColor;
            vehicleGatePass.VehiclePlateNumber = model.VehiclePlateNumber;
            vehicleGatePass.UpdatedBy = user.Id;
            vehicleGatePass.UpdatedOn = DateTime.UtcNow;

            _context.Update(vehicleGatePass);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

            
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


        // GET: VehicleGatePass/Approve/{id}
        public async Task<IActionResult> Approve(int id)
        {
            var vehicleGatePass = await _context.VehicleGatepasses
                .Include(v => v.ApplicationUser)
                .FirstOrDefaultAsync(v => v.VehicleId == id);

            if (vehicleGatePass == null)
            {
                return NotFound();
            }

            return View(vehicleGatePass);  // Display the vehicle gate pass to be approved
        }
        [HttpPost, ActionName("ApproveRejectConfirmed")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ApproveRejectConfirmed(int id, string action, string rejectionReason)
        {
            var vehicleGatePass = await _context.VehicleGatepasses.FindAsync(id);
            if (vehicleGatePass == null)
            {
                return NotFound();
            }

            if (action == "reject")
            {
                // Reject the gate pass
                vehicleGatePass.IsApproved = false;
                vehicleGatePass.RejectionReason = rejectionReason;
                vehicleGatePass.ApprovalStatus = "Rejected";
                vehicleGatePass.IsRejected = true;
            }
            else if (action == "approve")
            {
                // Approve the gate pass
                vehicleGatePass.IsApproved = true;
                vehicleGatePass.ApprovalStatus = "Approved";
                vehicleGatePass.ApprovalDate = DateTime.UtcNow;
                vehicleGatePass.GatePassIssuedDate = DateTime.UtcNow;
                vehicleGatePass.IsRejected = false;

                // Automatically set expiry date to one year from the issued date
                vehicleGatePass.GatePassExpiryDate = DateTime.UtcNow.AddYears(1); // Set expiry to 1 year after issued date
            }
                
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index)); // Redirect back to the list after approval/rejection
        }



        [HttpPost]
        [ActionName("DeleteConfirmed")]
        [ValidateAntiForgeryToken]
        [Route("VehicleGatePass/DeleteConfirmed/{id}")]
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
