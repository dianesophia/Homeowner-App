using Hometown_Application.Areas.Identity.Data;
using Hometown_Application.Data;
using Hometown_Application.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Hometown_Application.Controllers
{
    public class ContactController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public ContactController(ApplicationDBContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IActionResult> Index()
        {
            var contacts = _context.Contacts.Where(c => !c.IsDeleted).ToList();
            var user = await _userManager.GetUserAsync(User);
            var isAdmin = user != null && await _userManager.IsInRoleAsync(user, "Admin");

            ViewData["IsAdmin"] = isAdmin;
            return View(contacts);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Edit(int id)
        {
            var contact = _context.Contacts.Find(id);
            if (contact == null) return NotFound();

            return View(contact);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Edit(ContactModel contact)
        {
            if (ModelState.IsValid)
            {
                var existingContact = _context.Contacts.Find(contact.Id);
                if (existingContact == null) return NotFound();

                existingContact.ContactType = contact.ContactType;
                existingContact.Description = contact.Description;
                existingContact.UpdatedOn = DateTime.UtcNow;
                existingContact.UpdatedBy = User.Identity.Name;

                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contact);
        }
    }
}
