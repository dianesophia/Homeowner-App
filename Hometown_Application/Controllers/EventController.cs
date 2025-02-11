using Microsoft.AspNetCore.Mvc;
using Hometown_Application.Data;
using Hometown_Application.Models;
using System.Linq;

public class EventController : Controller
{
    private readonly AuthDBContext _context;

    public EventController(AuthDBContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }
    /*
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
        if (ModelState.IsValid)
        {
            _context.Events.Add(newEvent);
            _context.SaveChanges();
            return Json(new { success = true, message = "Event added successfully!" });
        }
        return BadRequest("Invalid event data");
    }*/

}
