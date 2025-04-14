using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using System.Linq;
using System.Threading.Tasks;
using System;
using Hometown_Application.Data;
using Hometown_Application.Models;
using Hometown_Application.Areas.Identity.Data;
using Hometown_Application.Hubs;
using Microsoft.EntityFrameworkCore;

[Authorize]
public class EventController : Controller
{
    private readonly ApplicationDBContext _context;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly IHubContext<NotificationHub> _notificationHubContext;

    public EventController(
        ApplicationDBContext context,
        UserManager<ApplicationUser> userManager,
        IHubContext<NotificationHub> notificationHubContext)
    {
        _context = context;
        _userManager = userManager;
        _notificationHubContext = notificationHubContext;
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
    public async Task<IActionResult> AddEvent([FromBody] EventModel newEvent)
    {
        try
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors)
                                              .Select(e => e.ErrorMessage);
                return BadRequest(new { success = false, message = "Invalid event data.", errors });
            }

            var adminUser = await _userManager.GetUserAsync(User);
            if (adminUser == null)
            {
                return Unauthorized(new { success = false, message = "Unauthorized request." });
            }

            newEvent.AddedBy = adminUser.Id;

            if (!string.IsNullOrEmpty(newEvent.UpdatedBy))
            {
                newEvent.UpdatedOn = DateTime.UtcNow;
            }

            _context.Events.Add(newEvent);
            await _context.SaveChangesAsync();

            // TODO: Replace "targetUserId" with actual recipient ID logic
            string targetUserId = adminUser.Id; // Replace with intended recipient if different
            await _notificationHubContext.Clients.User(targetUserId).SendAsync("ReceiveNotification", "A new event has been added.");

            return Json(new { success = true, message = "Event added successfully!" });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { success = false, message = "Error saving event.", error = ex.Message });
        }
    }
    [HttpPost]
    [Route("Event/UpdateEvent")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> UpdateEvent([FromBody] EventModel updatedEvent)
    {
        try
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors)
                                              .Select(e => e.ErrorMessage);
                return BadRequest(new { success = false, message = "Invalid event data.", errors });
            }

            var existingEvent = await _context.Events.FirstOrDefaultAsync(e => e.Id == updatedEvent.Id);


            if (existingEvent == null)
            {
                return NotFound(new { success = false, message = "Event not found." });
            }

            // Update properties
            existingEvent.Title = updatedEvent.Title;
            existingEvent.Description = updatedEvent.Description;
            existingEvent.DateTimeStart = updatedEvent.DateTimeStart;
            existingEvent.DateTimeEnd = updatedEvent.DateTimeEnd ?? updatedEvent.DateTimeStart;
            existingEvent.Location = updatedEvent.Location;
            existingEvent.Category = updatedEvent.Category;
            existingEvent.UpdatedBy = updatedEvent.UpdatedBy;
           // existingEvent.UpdatedAt = DateTime.UtcNow;

            await _context.SaveChangesAsync();

            return Ok(new { success = true, message = "Event updated successfully." });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { success = false, message = "An error occurred while updating the event.", error = ex.Message });
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
