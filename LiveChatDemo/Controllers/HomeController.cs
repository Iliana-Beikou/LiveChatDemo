using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LiveChatDemo.DAL;

namespace LiveChatDemo.Controllers
{
    public class HomeController : Controller
    {
        private MessagesDbContext _context;
        public HomeController()
        {
            _context = new MessagesDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Chat()
        {
            var messages = _context.Messages.ToList();
            return View(messages);
        }
    }
}