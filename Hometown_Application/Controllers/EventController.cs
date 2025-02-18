    using Microsoft.AspNetCore.Mvc;
    using Hometown_Application.Data;
    using Hometown_Application.Models;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using System.Linq;
    using Hometown_Application.Areas.Identity.Data;

    [Authorize]

    public class EventController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public EventController(ApplicationDBContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetEvents()
        {
            var events = _context.Events
                .Where(e => !e.IsDeleted)
                .Select(e => new
                {
                    id = e.Id,
                    title = e.Title,
                    start = e.DateTimeStart,
                    end = e.DateTimeEnd,
                    location = e.Location
                }).ToList();

            return Json(events);
        }

        [HttpPost]
        [Route("Event/AddEvent")]
    [Authorize(Roles = "Admin")]
    public IActionResult AddEvent([FromBody] EventModel newEvent)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var errors = ModelState.Values.SelectMany(v => v.Errors)
                                                  .Select(e => e.ErrorMessage);
                    return BadRequest(new { success = false, message = "Invalid event data.", errors });
                }

                var adminUser = _userManager.GetUserAsync(User).Result;
                if (adminUser != null)
                {
                    newEvent.AddedBy = adminUser.Id;
                }
                else
                {
                    return Unauthorized(new { success = false, message = "Unauthorized request." });
                }

                if (newEvent == null || string.IsNullOrEmpty(newEvent.Title) || string.IsNullOrEmpty(newEvent.AddedBy))
                {
                    return BadRequest(new { success = false, message = "Invalid event data." });
                }

                if (string.IsNullOrEmpty(newEvent.UpdatedBy))
                {
                  //  newEvent.UpdatedBy = null;
                    //newEvent.UpdatedOn = null;
                }
                else
                {
                    // If UpdatedBy is provided, update the UpdatedOn timestamp
                    newEvent.UpdatedOn = DateTime.UtcNow;
                }

                _context.Events.Add(newEvent);
                _context.SaveChanges();

                return Json(new { success = true, message = "Event added successfully!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = "Error saving event.", error = ex.Message });
            }
        }


        [HttpDelete]
    [Authorize(Roles = "Admin")]
    public IActionResult DeleteEvent(int id)
        {
            var eventToDelete = _context.Events.Find(id);
            if (eventToDelete == null)
                return NotFound();

            eventToDelete.IsDeleted = true;
            _context.SaveChanges();

            return Json(new { success = true, message = "Event deleted successfully!" });
        }
    }
