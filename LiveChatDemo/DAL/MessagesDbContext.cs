using LiveChatDemo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LiveChatDemo.DAL
{
    public class MessagesDbContext :DbContext
    {
        public MessagesDbContext() :base("DefaultConnection")
        {

        }

        public DbSet<Messages> Messages { get; set; }

        
    }
}