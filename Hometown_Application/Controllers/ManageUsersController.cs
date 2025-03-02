using Hometown_Application.Areas.Identity.Data;
using Hometown_Application.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hometown_Application.Controllers
{
    public class ManageUsersController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDBContext _dbContext;

        public ManageUsersController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, ApplicationDBContext dbContext)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _dbContext = dbContext;
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Index()
        {
            var users = _userManager.Users.ToList();
            var usersWithRoles = new List<(ApplicationUser User, string Role)>();

            foreach (var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user); 
                var role = roles.FirstOrDefault() ?? "No Role";
                usersWithRoles.Add((user, role));
            }

            return View(usersWithRoles);
        }

        public async Task<IActionResult> ChangeRole()
        {
            var users = _userManager.Users.ToList();
            var usersWithRoles = new List<(ApplicationUser User, string Role)>();

            foreach (var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user);
                var role = roles.FirstOrDefault() ?? "No Role";
                usersWithRoles.Add((user, role));
            }

            return View(usersWithRoles);
        }


      /*  public IActionResult ChangeUserRole(int page = 1)
        {
            int pageSize = 10; // Show only 10 users per page
            var users = _dbContext.Users
                                .Select(u => new { u, Role = _dbContext.UserRoles.Where(r => r.UserId == u.Id).Select(r => r.RoleId).FirstOrDefault() })
                                .OrderBy(u => u.u.FirstName)
                                .Skip((page - 1) * pageSize)
                                .Take(pageSize)
                                .ToList()
                                .Select(u => (u.u, u.Role));

            int totalUsers = _dbContext.Users.Count();
            int totalPages = (int)Math.Ceiling((double)totalUsers / pageSize);

            var viewModel = (users, totalPages, page);
            return View(viewModel);
        }*/

        [Authorize(Roles = "Admin")]
        [HttpPost] 
        public async Task<IActionResult> ChangeRole(string userId, string newRole)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null) return NotFound();

            var oldRoles = await _userManager.GetRolesAsync(user);
            await _userManager.RemoveFromRolesAsync(user, oldRoles); 

            if (!string.IsNullOrEmpty(newRole))
            {
                await _userManager.AddToRoleAsync(user, newRole); 
            }

            return RedirectToAction("Index"); 
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> ApproveHomeowner(string userId)
        {
            var homeownerProfile = _dbContext.HomeownerProfiles.FirstOrDefault(h => h.UserId == userId);

            if (homeownerProfile == null)
            {
                return NotFound("Homeowner profile not found.");
            }

            homeownerProfile.IsApproved = true;
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }






    }
}
