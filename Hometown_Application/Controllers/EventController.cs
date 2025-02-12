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
    public IActionResult AddEvent([FromBody] EventModel newEvent)
    {
        try
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid event data.");

          //  var adminId = _userManager.GetUserId(User); // Get admin's user ID
            //newEvent.AddedBy = adminId; 

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
