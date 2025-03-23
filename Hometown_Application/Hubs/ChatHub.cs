using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Hometown_Application.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string sender, string recipientId, string message)
        {
            await Clients.User(recipientId).SendAsync("ReceivePrivateMessage", sender, message);
            Console.WriteLine($"📢 SignalR Message Sent: {sender} -> {recipientId}");
        }
    }
}
