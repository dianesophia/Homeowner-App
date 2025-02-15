using Hometown_Application.Areas.Identity.Data;
using Hometown_Application.Data;
using Hometown_Application.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

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

        // GET: Contact
        public async Task<IActionResult> Index()
        {
            var contacts = await _context.Contacts
                .Where(c => !c.IsDeleted) // Only show active contacts
                .OrderBy(c => c.ContactType)
                .ToListAsync();
            return View(contacts);
        }

        // GET: Contact/Edit/{id}
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int id)
        {
            if (id == 0)
            {
                // Creating a new contact
                return View(new ContactModel());
            }

            var contact = await _context.Contacts.FindAsync(id);
            if (contact == null)
            {
                return NotFound();
            }
            return View(contact);
        }

        // POST: Contact/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,ContactType,Description,Number,AddedBy,UpdatedBy")] ContactModel contact)
        {
            if (!ModelState.IsValid)
            {
                return View(contact);
            }

            if (id == 0)
            {
                // New Contact
                contact.AddedOn = DateTime.UtcNow;
                _context.Add(contact);
            }
            else
            {
                // Update Existing Contact
                var existingContact = await _context.Contacts.FindAsync(id);
                if (existingContact == null)
                {
                    return NotFound();
                }

                existingContact.UserId = contact.UserId;
                existingContact.ContactType = contact.ContactType;
                existingContact.Description = contact.Description;
                existingContact.Number = contact.Number;
                existingContact.UpdatedOn = DateTime.UtcNow;
                existingContact.UpdatedBy = contact.UpdatedBy;

                _context.Update(existingContact);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        // POST: Contact/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")] // Only Admins can delete
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contact = await _context.Contacts.FindAsync(id);
            if (contact != null)
            {
                contact.IsDeleted = true;
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
