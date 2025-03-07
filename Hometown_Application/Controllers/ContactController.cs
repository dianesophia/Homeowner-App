using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hometown_Application.Data;
using Hometown_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hometown_Application.Areas.Identity.Data;
using Microsoft.AspNetCore.Mvc.Rendering; // ✅ Required for SelectListItem

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

        // ✅ GET: Load form for create/edit contact
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateEditContact(int? id)
        {
            ViewBag.ContactTypes = GetContactTypes(); // Ensure dropdowns load

            if (id == null)
            {
                return View(new ContactModel()); // Create new contact
            }

            var contactInDb = await _context.Contacts.FindAsync(id);
            if (contactInDb == null)
            {
                return NotFound();
            }

            return View(contactInDb); // Edit existing contact
        }

        // ✅ POST: Save contact (create or update)
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateEditContactForm(ContactModel model)
        {
            var user = await _userManager.GetUserAsync(User);
            var contactInDb = await _context.Contacts.SingleOrDefaultAsync(c => c.Id == model.Id);

            if (contactInDb == null)
            {
                model.AddedOn = DateTime.Now;
                model.AddedBy = user.Id;

                _context.Contacts.Add(model);
            }
            else
            {
                contactInDb.ContactType = model.ContactType;
                contactInDb.Description = model.Description;
                contactInDb.Number = model.Number;

                _context.Contacts.Update(contactInDb);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        // ✅ Soft delete contact
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteContact(int id)
        {
            var contactInDb = await _context.Contacts.FindAsync(id);
            if (contactInDb == null)
            {
                TempData["Message"] = "Contact not found.";
                return RedirectToAction(nameof(Index));
            }

            contactInDb.IsDeleted = true; // ✅ Soft delete
            await _context.SaveChangesAsync();

            TempData["Message"] = "Contact deleted successfully!";
            return RedirectToAction(nameof(Index));
        }

        // ✅ Populate contact types dropdown
        private List<SelectListItem> GetContactTypes()
        {
            return new List<SelectListItem>
            {
                new SelectListItem { Value = "Resident", Text = "Resident" },
                new SelectListItem { Value = "Security", Text = "Security" },
                new SelectListItem { Value = "Admin", Text = "Admin" },
                new SelectListItem { Value = "Emergency - General", Text = "Emergency - General" },
                new SelectListItem { Value = "Emergency - Fire Department", Text = "Emergency - Fire Department" },
                new SelectListItem { Value = "Emergency - Medical", Text = "Emergency - Medical" },
                new SelectListItem { Value = "Emergency - Disaster Response", Text = "Emergency - Disaster Response" },
                new SelectListItem { Value = "Maintenance - General", Text = "Maintenance - General" },
                new SelectListItem { Value = "Maintenance - Plumbing", Text = "Maintenance - Plumbing" },
                new SelectListItem { Value = "Maintenance - Electrical", Text = "Maintenance - Electrical" },
                new SelectListItem { Value = "Maintenance - Landscaping", Text = "Maintenance - Landscaping" },
                new SelectListItem { Value = "Maintenance - Pest Control", Text = "Maintenance - Pest Control" },
                new SelectListItem { Value = "Religious - Priest", Text = "Religious - Priest" },
                new SelectListItem { Value = "Religious - Pastor", Text = "Religious - Pastor" },
                new SelectListItem { Value = "Religious - Other", Text = "Religious - Other" }
            };
        }
    }
}
