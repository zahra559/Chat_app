using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chat_app.Data
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string sender ,string receiver, string msgTitle,string msgBody)
        {
            await Clients.All.SendAsync("ReceiveMessage", sender, receiver, msgTitle, msgBody);
        }
        public async Task SendMessage2(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage2", user, message);
        }
    }
}
