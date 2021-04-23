using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LiveChatDemo.Models;
using LiveChatDemo.DAL;

namespace LiveChatDemo
{
    public class ChatHub : Hub
    {

        private MessagesDbContext _context;
        public ChatHub()
        {
            _context = new MessagesDbContext();
        }
        public void Send(string name, string message)
        {
            Messages messages = new Messages() { Name=name , Message = message, Date = DateTime.Now};
            _context.Messages.Add(messages);
            _context.SaveChanges();

            // Call the addNewMessageToPage method to update clients.
            Clients.All.addNewMessageToPage(name, message);
            
        }
    }
}