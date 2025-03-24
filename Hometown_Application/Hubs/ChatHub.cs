using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Hometown_Application.Hubs
{
    public class ChatHub : Hub
    {
        private readonly ILogger<ChatHub> _logger;
        private static readonly ConcurrentDictionary<string, string> _userConnections = new ConcurrentDictionary<string, string>();

        public ChatHub(ILogger<ChatHub> logger)
        {
            _logger = logger;
        }

        public override async Task OnConnectedAsync()
        {
            var userId = Context.UserIdentifier;
            if (userId != null)
            {
                _userConnections[userId] = Context.ConnectionId;
                _logger.LogInformation($"✅ {userId} connected with ID {Context.ConnectionId}");
            }
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            var userId = Context.UserIdentifier;
            if (userId != null)
            {
                _userConnections.TryRemove(userId, out _);
                _logger.LogInformation($"❌ {userId} disconnected");
            }
            await base.OnDisconnectedAsync(exception);
        }
    }
}
