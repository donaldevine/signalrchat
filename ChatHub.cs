using System;
using Microsoft.AspNetCore.SignalR;

namespace signalrchat
{
    public class ChatHub: Hub
    {        
        public void Send(string name, string message){

            // Call the broadcastMessage method to update clients
            Clients.All.InvokeAsync("broadcastMessage", name, message);
        }
    }
}