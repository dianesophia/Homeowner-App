using Hometown_Application.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Hometown_Application.Hubs;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Linq;
using Hometown_Application.Areas.Identity.Data;
using Hometown_Application.Data;
using System.Collections.Generic;

namespace Hometown_Application.Controllers
{
    public class ChatController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly IHubContext<ChatHub> _hubContext;
        private readonly UserManager<ApplicationUser> _userManager;

        public ChatController(ApplicationDBContext context, IHubContext<ChatHub> hubContext, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _hubContext = hubContext;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string recipientId)
        {
            var sender = await _userManager.GetUserAsync(User);
            if (sender == null)
            {
                return Unauthorized();
            }

            // Get all users except the logged-in user
            var users = _userManager.Users.Where(u => u.Id != sender.Id).ToList();
            ViewBag.Users = users; // Send user list to View

            var messages = _context.Chats
                .Where(m => (m.SenderId == sender.Id && m.RecipientId == recipientId) ||
                            (m.SenderId == recipientId && m.RecipientId == sender.Id))
                .OrderBy(m => m.DateTime)
                .ToList();

            ViewBag.RecipientId = recipientId; // Send selected recipient to View
            return View(messages);
        }


        [HttpPost]
        public async Task<IActionResult> SendPrivateMessage([FromBody] ChatMessageModel chatData)
        {
            if (chatData == null || string.IsNullOrWhiteSpace(chatData.Message))
                return BadRequest("Invalid message data.");

            var sender = await _userManager.GetUserAsync(User);
            if (sender == null) return Unauthorized();

            var chatMessage = new ChatMessageModel
            {
                SenderId = sender.Id,
                RecipientId = chatData.RecipientId,
                Message = chatData.Message,
                DateTime = DateTime.Now
            };

            _context.Chats.Add(chatMessage);
            await _context.SaveChangesAsync();

            await _hubContext.Clients.User(chatMessage.RecipientId)
                .SendAsync("ReceivePrivateMessage", sender.UserName, chatMessage.Message);

            return Ok();
        }
    }
}
