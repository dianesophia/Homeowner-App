using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Hometown_Application.Areas.Identity.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Hometown_Application.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public DashboardController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UserManagement()
        {
            var users = await _userManager.Users.ToListAsync(); // Fetch all users

            foreach (var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user); // Fetch roles for each user
                user.PhoneNumber = roles.FirstOrDefault() ?? "No Role"; // Store role in an unused field (e.g., PhoneNumber)
            }

            return View(users);
        }
    }
}
