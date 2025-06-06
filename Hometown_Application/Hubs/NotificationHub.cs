﻿using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Hometown_Application.Hubs
{
    public class NotificationHub : Hub
    {
        public async Task SendNotification(string userId, string message)
        {
            await Clients.User(userId).SendAsync("ReceiveNotification", message);
        }
    }
}
