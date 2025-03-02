using Hometown_Application.Areas.Identity.Data;
using Hometown_Application.Data;
using Hometown_Application.Models;
using Hometown_Application.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Hometown_Application.Controllers
{
    public class CreateStaffController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public CreateStaffController(ApplicationDBContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

       
        public IActionResult Index()
        {
            return View(new CreateStaffViewModel());
        }

        public async Task<IActionResult> StaffList()
        { 
            var StaffProfiles = await _context.StaffProfiles
                .Include(s => s.ApplicationUser)
                .ToListAsync();

            return View(StaffProfiles);
        }

        [HttpPost]
        public async Task<IActionResult> CreateStaff(CreateStaffViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Step 1: Create a new ApplicationUser
                var user = new ApplicationUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName
                };

                var result = await _userManager.CreateAsync(user, "DefaultPassword123!"); // Default password, admin can reset later
                if (!result.Succeeded)
                {
                    ModelState.AddModelError("", "Error creating user: " + string.Join(", ", result.Errors.Select(e => e.Description)));
                    return View(model);
                }

                // Step 2: Create a new StaffProfile linked to this user
                var staffProfile = new StaffProfileModel
                {
                    UserId = user.Id, // Link to ApplicationUser
                    Position = model.Position,
                    HireDate = model.HireDate,
                    Salary = model.Salary
                };

                _context.StaffProfiles.Add(staffProfile);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index", "StaffProfile"); // Redirect to staff list
            }

            return View(model);
        }



    }
}