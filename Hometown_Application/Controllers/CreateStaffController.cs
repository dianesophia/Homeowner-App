using Hometown_Application.Areas.Identity.Data;
using Hometown_Application.Data;
using Hometown_Application.Models;
using Hometown_Application.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Hometown_Application.Controllers
{
    public class CreateStaffController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public CreateStaffController(ApplicationDBContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View(new CreateStaffViewModel());
        }

        public async Task<IActionResult> StaffList()
        {
            var staffProfiles = await _context.StaffProfiles
                .Include(s => s.ApplicationUser)
                .ToListAsync();

            return View(staffProfiles);
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

                // Step 2: Ensure the "Staff" role exists
                if (!await _roleManager.RoleExistsAsync("Staff"))
                {
                    await _roleManager.CreateAsync(new IdentityRole("Staff"));
                }

                // Step 3: Assign the "Staff" role to the user
                await _userManager.AddToRoleAsync(user, "Staff");

                // Step 4: Create a new StaffProfile linked to this user
                var staffProfile = new StaffProfileModel
                {
                    UserId = user.Id, // Link to ApplicationUser
                    Position = model.Position,
                    HireDate = model.HireDate,
                    Salary = model.Salary
                };

                _context.StaffProfiles.Add(staffProfile);
                await _context.SaveChangesAsync();

                return RedirectToAction("StaffList");
            }

            return View(model);
        }
    }
}
