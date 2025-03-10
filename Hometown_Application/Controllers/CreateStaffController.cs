using Hometown_Application.Areas.Identity.Data;
using Hometown_Application.Data;
using Hometown_Application.Models;
using Hometown_Application.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
                .Where(s => _context.UserRoles
                    .Any(ur => ur.UserId == s.ApplicationUser.Id &&
                               _context.Roles.Any(r => r.Id == ur.RoleId && r.Name == "Staff")))
                .ToListAsync();

            return View(staffProfiles);
        }



        public IActionResult CreateStaff()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> CreateStaff(CreateStaffViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Get the logged-in user's details
            var loggedInUser = await _userManager.GetUserAsync(User);
            string createdBy = loggedInUser?.Id ?? "System"; // Use "System" if no user is logged in

            // Create a new ApplicationUser
            var user = new ApplicationUser
            {
                UserName = model.Email,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                PhoneNumber = model.PhoneNumber,
            };

            // Create the user with the provided password
            var result = await _userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Error creating user: " + string.Join(", ", result.Errors.Select(e => e.Description)));
                return View(model);
            }
            user.PhoneNumber = model.PhoneNumber;
            await _userManager.UpdateAsync(user);
            // Check if the "Staff" role exists, if not, create it
            if (!await _roleManager.RoleExistsAsync("Staff"))
            {
                await _roleManager.CreateAsync(new IdentityRole("Staff"));
            }

            // Assign the new user to the "Staff" role
            await _userManager.AddToRoleAsync(user, "Staff");

            // Create the staff profile entry
            var staffProfile = new StaffProfileModel
            {
                UserId = user.Id,
                Position = model.Position,
                HireDate = model.HireDate,
                Salary = model.Salary,
                Department = model.Department,
                IsActiveEmployee = model.IsActiveEmployee,
                IsAlsoHomeOwner = model.IsAlsoHomeOwner,
                Address = model.Address,
                EmergencyContactName = model.EmergencyContactName,
                EmergencyContactNumber = model.EmergencyContactNumber,
                EmergencyContactRelation = model.EmergencyContactRelation,
                AccountCreatedBy = createdBy, // Use logged-in user's ID
                AccountCreatedOn = DateTime.UtcNow,
                UpdatedOn = DateTime.UtcNow,
            };

            // Save to database
            _context.StaffProfiles.Add(staffProfile);
            await _context.SaveChangesAsync();

            return RedirectToAction("StaffList");
        }

    }
}
