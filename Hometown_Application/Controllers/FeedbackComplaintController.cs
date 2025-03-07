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
using System.Linq;

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
            var statuses = _context.Status.ToList();
            ViewBag.Statuses = statuses;

            var feedbackComplaints = _context.FeedbackComplaints
                .Include(f => f.Status)
                .Include(f => f.ApplicationUser)
                .ToList();

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
            if (user == null) return RedirectToAction("FeedbackStatusReport");

            model.UserId = user.Id;
            model.AddedBy = user.Id;
            model.AddedOn = DateTime.UtcNow;
            model.Type = "Feedback";

            var pendingStatus = await _context.Status.FirstOrDefaultAsync(s => s.StatusName == "Pending");
            if (pendingStatus == null) return BadRequest("Pending status not found.");
            model.StatusId = pendingStatus.StatusId;

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
            return RedirectToAction("FeedbackStatusReport");
        }

        public IActionResult Complaint()
        {
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> ComplaintForm(FeedbackComplaintModel model, IFormFile Image)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return RedirectToAction("ComplaintStatusReport");

            model.UserId = user.Id;
            model.AddedBy = user.Id;
            model.AddedOn = DateTime.UtcNow;
            model.Type = "Complaint";

            var pendingStatus = await _context.Status.FirstOrDefaultAsync(s => s.StatusName == "Pending");
            if (pendingStatus == null) return BadRequest("Pending status not found.");
            model.StatusId = pendingStatus.StatusId;

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
            return RedirectToAction("ComplaintStatusReport");
        }

        [Authorize(Roles = "HomeOwner")]
        public async Task<IActionResult> FeedbackStatusReport()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return View();

            var list = await _context.FeedbackComplaints
                .Where(f => f.UserId == user.Id && !f.IsDeleted)
                .Include(f => f.Status)
                .ToListAsync();

            return View(list);
        }
        [Authorize(Roles = "HomeOwner")]
        public async Task<IActionResult> ComplaintStatusReport()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return View();

            var list = await _context.FeedbackComplaints
                .Where(f => f.UserId == user.Id && !f.IsDeleted)
                .Include(f => f.Status)
                .ToListAsync();

            return View(list);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ManageFeedback()
        {
            var feedbackComplaints = await _context.FeedbackComplaints
                .Include(f => f.Status)
                .Include(f => f.ApplicationUser)
                .ToListAsync();

            return View(feedbackComplaints);
        }

        [Authorize(Roles = "Admin")]

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ReplyToFeedback(int id, string replyMessage)
        {
            var feedback = await _context.FeedbackComplaints.FindAsync(id);
            if (feedback == null) return NotFound();

            feedback.AdminReply = replyMessage;
            feedback.UpdatedOn = DateTime.UtcNow;

            var inProgressStatus = await _context.Status.FirstOrDefaultAsync(s => s.StatusName == "In Progress");
            if (inProgressStatus == null) return BadRequest("In Progress status not found.");

            //feedback.StatusId = 4;

            _context.Update(feedback);
            await _context.SaveChangesAsync();

            return RedirectToAction("ManageFeedback");
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
            public async Task<IActionResult> FeedbackUpdateStatus(int id, string newStatus)
            {
                if (id == 0)
                {
                    return RedirectToAction("Index");
                }

                var feedback = await _context.FeedbackComplaints.Include(f => f.Status).FirstOrDefaultAsync(f => f.FeedbackComplaintId == id);
                if (feedback != null)
                {
                    var status = await _context.Status.FirstOrDefaultAsync(s => s.StatusName == newStatus);
                    if (status != null)
                    {
                        feedback.StatusId = status.StatusId; 
                        await _context.SaveChangesAsync();

                        TempData["ActiveTab"] = newStatus;
                    }
                }

                return RedirectToAction("ManageFeedback", new { selectedStatus = newStatus });
            }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ManageComplaint()
        {
            var feedbackComplaints = await _context.FeedbackComplaints
                .Include(f => f.Status)
                .Include(f => f.ApplicationUser)
                .ToListAsync();

            return View(feedbackComplaints);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ReplyToComplaint(int id, string replyMessage)
        {
            var feedback = await _context.FeedbackComplaints.FindAsync(id);
            if (feedback == null) return NotFound();

            feedback.AdminReply = replyMessage;
            feedback.UpdatedOn = DateTime.UtcNow;

            var inProgressStatus = await _context.Status.FirstOrDefaultAsync(s => s.StatusName == "In Progress");
            if (inProgressStatus == null) return BadRequest("In Progress status not found.");

            //feedback.StatusId = 4;

            _context.Update(feedback);
            await _context.SaveChangesAsync();

            return RedirectToAction("ManageComplaint");
        }


        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> ComplaintUpdateStatus(int id, string newStatus)
        {
            if (id == 0)
            {
                return RedirectToAction("Index");
            }

            var feedback = await _context.FeedbackComplaints.Include(f => f.Status).FirstOrDefaultAsync(f => f.FeedbackComplaintId == id);
            if (feedback != null)
            {
                var status = await _context.Status.FirstOrDefaultAsync(s => s.StatusName == newStatus);
                if (status != null)
                {
                    feedback.StatusId = status.StatusId;
                    await _context.SaveChangesAsync();

                    TempData["ActiveTab"] = newStatus;
                }
            }

            return RedirectToAction("ManageComplaint", new { selectedStatus = newStatus });
        }



        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> FeedbackAddNote(int id, string note)
        {
            var feedback = await _context.FeedbackComplaints.FindAsync(id);
            if (feedback == null) return NotFound();

            feedback.AdminNote = note;
            await _context.SaveChangesAsync();

            return RedirectToAction("ManageFeedback");
        }


        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> ComplaintAddNote(int id, string note)
        {
            var feedback = await _context.FeedbackComplaints.FindAsync(id);
            if (feedback == null) return NotFound();

            feedback.AdminNote = note;
            await _context.SaveChangesAsync();

            return RedirectToAction("ManageFeedback");
        }
    }
}
