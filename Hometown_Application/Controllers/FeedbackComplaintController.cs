using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Hometown_Application.Areas.Identity.Data;
using Hometown_Application.Data;
using Hometown_Application.Models;
using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Hometown_Application.Controllers
{
    public class FeedbackComplaintController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public FeedbackComplaintController(ApplicationDBContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        
        [HttpPost]
        public async Task<IActionResult> FeedbackForm(FeedbackComplaintModel model, IFormFile Image)
        {
            var user = await _userManager.GetUserAsync(User);

            if (user != null)
            {
                
                model.UserId = user.Id;
                model.AddedBy = user.Id;
                model.AddedOn = DateTime.UtcNow;
                model.Type = "Feedback";

                
                if (Image != null && Image.Length > 0)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        await Image.CopyToAsync(memoryStream);
                        model.Image = memoryStream.ToArray(); 
                    }
                }

                
                _context.FeedbackComplaints.Add(model);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("FCStatusReport");
        }

      
        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult Feedback()
        {
            return View();
        }

      
        public IActionResult Complaint()
        {
            return View();
        }

       
        public IActionResult AdminView()
        {
            return View();
        }

       
        public async  Task<IActionResult> FCStatusReport()
        {
            var user = await _userManager.GetUserAsync(User);

            if (user != null)
            {
                var feedbackList = await _context.FeedbackComplaints
                                                  .Where(f => f.UserId == user.Id && !f.IsDeleted)
                                                  .ToListAsync();

                return View(feedbackList);
            }

            return RedirectToAction("Feedback");
        }
    }
}
