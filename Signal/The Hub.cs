using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Signal
{
    public class The_Hub : Hub
    {
        public void SendMessage(string name, string message)
        {
            Clients.All.addNewMessageToPage(name, message);
        }
    }
}