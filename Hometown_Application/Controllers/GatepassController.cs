using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Hometown_Application.Data;
using Hometown_Application.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Hometown_Application.Areas.Identity.Data;

namespace Hometown_Application.Controllers
{
    [Authorize]
    public class GatepassController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        // Inject UserManager<ApplicationUser>
        public GatepassController(ApplicationDBContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Gatepasses
        public async Task<IActionResult> Index()
        {
            var gatepasses = await _context.Gatepass.ToListAsync();
            return View(gatepasses);
        }

        // GET: Gatepasses/CreateGatepass
        public IActionResult CreateGatepass()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateGatepass(GatepassModel gatepass)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Invalid data");
                return View(gatepass);
            }

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                ModelState.AddModelError("", "User not found. Please log in.");
                return View(gatepass);
            }

            // Debugging log
            Console.WriteLine($"User ID: {user.Id}");

            gatepass.UserId = user.Id;
            gatepass.PassNumber = "GP-" + Guid.NewGuid().ToString().Substring(0, 8).ToUpper();
            gatepass.CreatedAt = DateTime.UtcNow;

            try
            {
                _context.Add(gatepass);
                await _context.SaveChangesAsync();
                Console.WriteLine("Gatepass saved successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving gatepass: {ex.Message}");
                ModelState.AddModelError("", "Error saving to the database");
                return View(gatepass);
            }

            return RedirectToAction(nameof(Index));
        }


        // GET: Gatepasses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var gatepass = await _context.Gatepass.FindAsync(id);
            if (gatepass == null) return NotFound();

            return View(gatepass);
        }

        // POST: Gatepasses/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, GatepassModel gatepass)
        {
            if (id != gatepass.GatepassId) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    gatepass.UpdatedAt = DateTime.UtcNow;
                    _context.Update(gatepass);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Gatepass.Any(e => e.GatepassId == id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(gatepass);
        }

        // GET: Gatepasses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var gatepass = await _context.Gatepass.FindAsync(id);
            if (gatepass == null) return NotFound();

            return View(gatepass);
        }

        // POST: Gatepasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gatepass = await _context.Gatepass.FindAsync(id);
            if (gatepass != null)
            {
                gatepass.IsDeleted = true;
                gatepass.DeletedAt = DateTime.UtcNow;
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
