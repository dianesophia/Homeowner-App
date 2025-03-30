using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Hometown_Application.Data;
using Hometown_Application.Hubs;
using Hometown_Application.Models;
using System;

namespace Hometown_Application.Controllers
{
    [Authorize]
    public class ChatController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly IHubContext<ChatHub> _hubContext;
        private readonly IHubContext<NotificationHub> _notificationHubContext;


        public ChatController(ApplicationDBContext context, IHubContext<ChatHub> hubContext, IHubContext<NotificationHub> notificationHubContext)
        {
            _context = context;
            _hubContext = hubContext;
            _notificationHubContext = notificationHubContext;
        }

        public async Task<IActionResult> Index()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            ViewBag.Users = await _context.Users
                .Where(u => u.Id != userId)
                .Select(u => new { u.Id, u.UserName, u.FirstName, u.LastName, u.ProfilePicture })
                .ToListAsync();

            return View(await _context.Chats
                .Where(m => m.SenderId == userId || m.RecipientId == userId)
                .OrderBy(m => m.DateTime)
                .ToListAsync());
        }

        [HttpGet]
        public async Task<IActionResult> GetMessages(string recipientId)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var messages = await _context.Chats
                .Where(m => (m.SenderId == userId && m.RecipientId == recipientId) ||
                            (m.SenderId == recipientId && m.RecipientId == userId))
                .OrderBy(m => m.DateTime)
                .Select(m => new { sender = m.SenderId == userId ? "You" : "Them", message = m.Message })
                .ToListAsync();

            return Json(messages);
        }

        [HttpPost]
        public async Task<IActionResult> SendPrivateMessage([FromBody] ChatMessageModel model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var chatMessage = new ChatMessageModel
            {
                SenderId = userId,
                RecipientId = model.RecipientId,
                Message = model.Message,
                DateTime = DateTime.Now
            };

            _context.Chats.Add(chatMessage);
            await _context.SaveChangesAsync();

            await _hubContext.Clients.User(model.RecipientId).SendAsync("ReceivePrivateMessage", "Them", model.Message);

            await _notificationHubContext.Clients.User(model.RecipientId).SendAsync("ReceiveNotification", "New message received!");

            return Ok();
        }
    }
}
