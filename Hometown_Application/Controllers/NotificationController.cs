using Hometown_Application.Hubs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Hometown_Application.Controllers
{
    [Route("api/notifications")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly IHubContext<NotificationHub> _hubContext;

        public NotificationController(IHubContext<NotificationHub> hubContext)
        {
            _hubContext = hubContext;
        }

        [HttpPost("send")]
        public async Task<IActionResult> SendNotification([FromBody] string message)
        {
            await _hubContext.Clients.All.SendAsync("ReceiveNotification", message);
            return Ok(new { Message = "Notification sent successfully!" });
        }
    }
}
