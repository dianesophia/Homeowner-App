using Hometown_Application.Areas.Identity.Data;
using Hometown_Application.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hometown_Application.Controllers
{
    [Authorize(Roles = "Admin")]
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

        public async Task<IActionResult> Index()
        {
            var users = await _userManager.Users.ToListAsync();
            var userRoles = new List<(ApplicationUser User, string Role)>();

            foreach (var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user);
                var role = roles.FirstOrDefault() ?? "No Role";
                userRoles.Add((user, role));
            }

            return View(userRoles);
        }

         async Task<IActionResult> ViewDetails(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }
        /*
        public async Task<IActionResult> ApproveUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            
            if (user == null)
            {
                return NotFound();
            }

            user.IsApproved = true;
            await _userManager.UpdateAsync(user);

            // Redirect back to the index page
            return RedirectToAction(nameof(Index));
        }*/

        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            await _userManager.DeleteAsync(user);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ChangeRole()
        {
            var usersWithRoles = await GetUsersWithRoles();
            return View(usersWithRoles);
        }

        [HttpPost]
        public async Task<IActionResult> ChangeRole(string userId, string newRole)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null) return NotFound("User not found.");

            var oldRoles = await _userManager.GetRolesAsync(user);
            await _userManager.RemoveFromRolesAsync(user, oldRoles);

            if (!string.IsNullOrEmpty(newRole))
            {
                await _userManager.AddToRoleAsync(user, newRole);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        [HttpPost]
        public async Task<IActionResult> ApproveHomeowner(string userId)
        {
            var homeownerProfile = await _dbContext.HomeownerProfiles.FirstOrDefaultAsync(h => h.UserId == userId);
            if (homeownerProfile == null)
                return NotFound("Homeowner profile not found.");

            var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == userId);
            if (user == null)
                return NotFound("User not found.");

            homeownerProfile.IsApproved = true;
            user.IsApproved = true;

            _dbContext.HomeownerProfiles.Update(homeownerProfile);
            _dbContext.Users.Update(user);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }


        public async Task<IActionResult> AccountApproval()
        {
            var usersWithRoles = await GetUsersWithRoles();
            return View(usersWithRoles);
        }

        public async Task<IActionResult> HomeownerProfilesList()
        {
            var homeownerProfiles = await _dbContext.HomeownerProfiles
                .Include(h => h.ApplicationUser) // Corrected navigation property
                .ToListAsync();

            return View(homeownerProfiles);
        }

        private async Task<List<(ApplicationUser User, string Role)>> GetUsersWithRoles()
        {
            var users = _userManager.Users.ToList();
            var usersWithRoles = new List<(ApplicationUser User, string Role)>();

            foreach (var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user);
                var role = roles.FirstOrDefault() ?? "No Role";
                usersWithRoles.Add((user, role));
            }

            return usersWithRoles;
        }
    }
}