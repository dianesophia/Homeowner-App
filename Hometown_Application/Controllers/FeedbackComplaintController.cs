using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Hometown_Application.Areas.Identity.Data;
using Microsoft.AspNetCore.Authorization;
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

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Feedback()
        {
            return View();
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


                var pendingStatus = await _context.Status.FirstOrDefaultAsync(s => s.StatusName == "Pending");
                model.StatusId = pendingStatus?.StatusId;

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

      
        public IActionResult Complaint()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> ComplaintForm(FeedbackComplaintModel model, IFormFile Image)
        {
            var user = await _userManager.GetUserAsync(User);

            if (user != null)
            {

                model.UserId = user.Id;
                model.AddedBy = user.Id;
                model.AddedOn = DateTime.UtcNow;
                model.Type = "Complaint";

                var pendingStatus = await _context.Status.FirstOrDefaultAsync(s => s.StatusName == "Pending");
                model.StatusId = pendingStatus?.StatusId;

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
       
        public async  Task<IActionResult> FCStatusReport()
        {
            var user = await _userManager.GetUserAsync(User);

            if (user != null)
            {
                var list = await _context.FeedbackComplaints
                                                  .Where(f => f.UserId == user.Id && !f.IsDeleted)
                                                  .Include(f => f.Status)
                                                  .ToListAsync();

                return View(list);
            }

            
            return View();
        }

      public async Task<IActionResult> AdminView()
        {
            var feedbackComplaints = await _context.FeedbackComplaints
                .Include(f => f.Status) 
                .ToListAsync();

            return View(feedbackComplaints); 
        }
     

     /*   [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AdminView(int? id)
        {
            if (id == null)
            {
                return View(new FeedbackComplaintModel());
            }

            var issueInDb = await _context.FeedbackComplaints.FindAsync(id);
            if (issueInDb == null)
            {
                return NotFound();
            }

            return View(issueInDb);
        }*/


        [HttpPost]
        [ValidateAntiForgeryToken] // Optional but recommended for security
        [Route("FeedbackComplaint/ReplyToFeedback")]
        public async Task<IActionResult> ReplyToFeedback(int id, string replyMessage)
        {
            var feedback = await _context.FeedbackComplaints.FindAsync(id);

            if (feedback == null)
            {
                return NotFound(); // Return 404 if no feedback found
            }

            feedback.AdminReply = replyMessage;
            await _context.SaveChangesAsync(); // Save the reply

            return RedirectToAction("AdminView"); // Redirect back to admin view
        }


    }
}
