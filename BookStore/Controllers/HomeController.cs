using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        BookContext db = new BookContext();
        public ActionResult Index()
        {
            IEnumerable<Book> iBooksContext = db.Books;
            ViewBag.Message = "you see books";
            return View(iBooksContext);
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
    }
}