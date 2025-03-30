using Microsoft.AspNetCore.Mvc;
using Hometown_Application.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using Hometown_Application.Data;
using Hometown_Application.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Hometown_Application.Controllers
{
    public class BillItemsController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public BillItemsController(ApplicationDBContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: BillItems
        public async Task<IActionResult> Index()
        {
            var billItems = await _context.BillItems
                .Where(b => !b.IsDeleted)
                .ToListAsync();

         

            return View(billItems);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BillItemsModel model)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return RedirectToAction("Index");

            model.AddedOn = DateTime.UtcNow;
            model.AddedBy = user.Id;
            _context.BillItems.Add(model);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var billItems = await _context.BillItems.FindAsync(id);
            if (billItems == null) return RedirectToAction("Index");
            return View(billItems);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, BillItemsModel model)
        {
            if (id != model.BillItemsID)
            {
                return BadRequest();
            }

            var billItems = await _context.BillItems.FindAsync(id);
            if (billItems == null)
            {
                return NotFound();
            }

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return Unauthorized();
            }

            // ✅ Corrected property updates
            billItems.PaymentName = model.PaymentName;
            billItems.Amount = model.Amount;
            billItems.Description = model.Description;
            billItems.PaymentDuration = model.PaymentDuration;
            billItems.UpdatedOn = DateTime.UtcNow;
            billItems.UpdatedBy = user.Id;  // Make sure your model has these fields

            try
            {
                _context.Update(billItems);
                await _context.SaveChangesAsync();
                TempData["Message"] = "Updated successfully!";
            }
            catch (DbUpdateConcurrencyException)
            {
                TempData["Message"] = "Failed to update. Please try again.";
            }

            return RedirectToAction(nameof(Index));
        }


        // POST: BillItems/Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var billItem = await _context.BillItems.FindAsync(id);
            if (billItem == null)
            {
                return NotFound();
            }

            _context.BillItems.Remove(billItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
