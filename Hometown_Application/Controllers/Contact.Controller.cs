using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hometown_Application.Data;
using Hometown_Application.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using Hometown_Application.Areas.Identity.Data;

namespace Hometown_Application.Controllers
{
    [Authorize]
    public class ContactController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public ContactController(ApplicationDBContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var contacts = await _context.Contacts
                .Where(c => !c.IsDeleted)
                .OrderBy(c => c.ContactType)
                .ToListAsync();
            return View(contacts);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateEditContact(int? id)
        {
            if (id != null)
            {
                // Edit existing contact
                var contactInDb = await _context.Contacts.SingleOrDefaultAsync(c => c.Id == id);
                if (contactInDb == null)
                {
                    return NotFound();
                }
                return View(contactInDb);
            }

            // Create new contact
            return View(new ContactModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateEditContactForm(ContactModel model)
        {
            if (!ModelState.IsValid)
            {
                // Log validation errors
                foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                {
                    Console.WriteLine($"Validation Error: {error.ErrorMessage}");
                }
                return View("CreateEditContact", model);
            }

            if (model.Id == 0)
            {
                // Create new contact
                model.UserId = _userManager.GetUserId(User);
                model.AddedBy = User.Identity.Name;
                model.AddedOn = DateTime.UtcNow;
                _context.Contacts.Add(model);
            }
            else
            {
                // Edit existing contact
                var contactInDb = await _context.Contacts.SingleOrDefaultAsync(c => c.Id == model.Id);
                if (contactInDb == null)
                {
                    return NotFound();
                }

                contactInDb.UserId = model.UserId;
                contactInDb.ContactType = model.ContactType;
                contactInDb.Description = model.Description;
                contactInDb.Number = model.Number;
                contactInDb.UpdatedOn = DateTime.UtcNow;
                contactInDb.UpdatedBy = User.Identity.Name;
                _context.Contacts.Update(contactInDb);
            }

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"Error saving to database: {ex.Message}");
                ModelState.AddModelError("", "An error occurred while saving the contact.");
                return View("CreateEditContact", model);
            }

            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteContact(int id)
        {
            var contactInDb = await _context.Contacts.SingleOrDefaultAsync(c => c.Id == id);
            if (contactInDb != null)
            {
                contactInDb.IsDeleted = true;
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}