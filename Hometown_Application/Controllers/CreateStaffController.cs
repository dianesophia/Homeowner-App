using Hometown_Application.Data;
using Hometown_Application.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Hometown_Application.Controllers
{
    public class CreateStaffController : Controller
    {
        private readonly ApplicationDBContext _context;

        public CreateStaffController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: CreateStaff
        public IActionResult Index()
        {
            return View(new StaffProfileModel());
        }

        // POST: CreateStaff
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,Position,HireDate,Salary,IsActiveEmployee,IsAlsoHomeOwner,Address,EmergencyContactName,EmergencyContactNumber,EmergencyContactRelation")] StaffProfileModel staffProfile)
        {
            if (ModelState.IsValid)
            {
                _context.Add(staffProfile);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "StaffProfile");
            }
            return View("Index", staffProfile);
        }
    }
}