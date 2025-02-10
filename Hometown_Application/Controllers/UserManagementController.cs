using Hometown_Application.Areas.Identity.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Hometown_Application.Controllers
{
    public class UserManagementController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserManagementController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
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

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ChangeRole(string userId, string newRole)
        {
            /* if (string.IsNullOrEmpty(userId))
                 return NotFound();

             var user = await _userManager.FindByIdAsync(userId);
             if (user == null) return NotFound();

             var roles = await _userManager.GetRolesAsync(user);
             var userRole = roles.FirstOrDefault() ?? "No Role";

             ViewBag.UserId = user.Id;
             ViewBag.CurrentRole = userRole;

             return View(); // Return the form view*/

            var user = await _userManager.FindByIdAsync(userId);
            if (user == null) return NotFound();

            var oldRoles = await _userManager.GetRolesAsync(user);
            await _userManager.RemoveFromRolesAsync(user, oldRoles); // Remove old role

            if (!string.IsNullOrEmpty(newRole))
            {
                await _userManager.AddToRoleAsync(user, newRole); // Assign new role
            }

            return RedirectToAction("UserManagement"); // Reload the page to show updated roles



        }

        }
}
