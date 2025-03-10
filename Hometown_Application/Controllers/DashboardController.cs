using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Hometown_Application.Areas.Identity.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Hometown_Application.Data;
using Hometown_Application.Models;


namespace Hometown_Application.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDBContext _context;

        public DashboardController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, ApplicationDBContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var totalUsers = await _userManager.Users.CountAsync();
            //var activeIssues = await _context.FeedbackComplaints.Where(f => f.Status == "Open").CountAsync();
            var totalDocuments = await _context.Documents.CountAsync();

            var model = new DashboardViewModel
            {
                TotalUsers = totalUsers,
                //ActiveIssues = activeIssues,
                TotalDocuments = totalDocuments
            };

            return View(model);
        }
    }
}