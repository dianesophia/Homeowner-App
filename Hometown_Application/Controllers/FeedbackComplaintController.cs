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

        public async Task<IActionResult> Index()
        {
            var feedbackComplaints = await _context.FeedbackComplaints
                .Include(f => f.Status)
                .Include(f => f.ApplicationUser)
                .ToListAsync();

            var statuses = await _context.Status.ToListAsync();
            ViewBag.Statuses = statuses;

            return View(feedbackComplaints);
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
                .Include(f => f.ApplicationUser)
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
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ReplyToFeedback(int id, string replyMessage)
        {
            var feedback = await _context.FeedbackComplaints.FindAsync(id);

            if (feedback == null)
            {
                return NotFound(); 
            }

            feedback.AdminReply = replyMessage;
            feedback.UpdatedOn = DateTime.UtcNow;
            feedback.StatusId = 4;

            _context.Update(feedback); 
            await _context.SaveChangesAsync(); 

            return RedirectToAction("AdminView"); 
        }


        [HttpPost]
        public async Task<IActionResult> UpdateStatus(int id, string status)
        {
            var fcDb = await _context.FeedbackComplaints.FindAsync(id);
            if (fcDb == null) return NotFound();

            var statusEntity = await _context.Status.FirstOrDefaultAsync(s => s.StatusName == status);
            if (statusEntity == null) return BadRequest("Invalid status.");

            fcDb.StatusId = statusEntity.StatusId;
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }



        [HttpPost]
        public IActionResult AddNote(int id, string note)
        {
            var feedback = _context.FeedbackComplaints.Find(id);
            if (feedback != null)
            {
                feedback.AdminNote = note;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }




    }
}
