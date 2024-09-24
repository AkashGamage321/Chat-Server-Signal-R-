using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace ChatApp.Hubs
{
    public class ChatHub:Hub
    {
        public async Task SendMessage(string userName , string message)
        {
            await Clients.All.SendAsync("ReceiveMessage" , userName , message);
        }
        public async Task JoinChat(string userName)
        {
            await Clients.All.SendAsync("UserJoined" , userName);
        }
        public override async Task OnDisconnectedAsync(Exception exception)
        {
            var userName = Context.User.Identity.Name;
            await Clients.All.SendAsync("UserLeft" , userName);

            await base.OnDisconnectedAsync(exception);
        }
        
    }
}