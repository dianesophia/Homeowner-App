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
            return View(new CreateStaffViewModel());
        }



        [HttpPost]
        [HttpPost]
        public async Task<IActionResult> CreateStaff(CreateStaffViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var loggedInUser = await _userManager.GetUserAsync(User);
            string createdBy = loggedInUser?.Id ?? "System";

            var user = new ApplicationUser
            {
                UserName = model.Email,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                PhoneNumber = model.PhoneNumber,
            };

            var result = await _userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Error creating user: " + string.Join(", ", result.Errors.Select(e => e.Description)));
                return View(model);
            }

            user.PhoneNumber = model.PhoneNumber;
            await _userManager.UpdateAsync(user);

            if (!await _roleManager.RoleExistsAsync("Staff"))
            {
                await _roleManager.CreateAsync(new IdentityRole("Staff"));
            }

            await _userManager.AddToRoleAsync(user, "Staff");

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
                AccountCreatedBy = createdBy,
                AccountCreatedOn = DateTime.UtcNow,
                UpdatedOn = DateTime.UtcNow,
            };

            _context.StaffProfiles.Add(staffProfile);
            await _context.SaveChangesAsync();

            if (model.IsAlsoHomeOwner)
            {
                if (string.IsNullOrEmpty(model.BlockNumber) || string.IsNullOrEmpty(model.StreetName))
                {
                    ModelState.AddModelError("", "Block number and street name are required for homeowners.");
                    return View(model);
                }
                var existingHouse = _context.Houses.FirstOrDefault(h =>
     h.BlockNumber.ToLower() == model.BlockNumber.ToLower() &&
     h.LotNumber == model.LotNumber && // Direct comparison
     h.StreetName.Trim().ToLower() == model.StreetName.Trim().ToLower());



                Console.WriteLine("Existing House: " + (existingHouse != null ? "FOUND" : "NOT FOUND"));

                if (existingHouse != null)
                {
                    ModelState.AddModelError("", "A house with this address is already occupied.");
                    return View(model);
                }

                var house = new HouseModel
                {
                    UserId = user.Id,
                    BlockNumber = model.BlockNumber,
                    LotNumber = model.LotNumber ?? 0,
                    StreetName = model.StreetName,
                    IsOccupied = true
                };

                _context.Houses.Add(house);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("StaffList");
        }


    }
}
