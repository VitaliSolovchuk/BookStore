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

        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.BookId = id;
            return View();
        }

        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            WorkWithBbAdd(purchase);

            return "спасибо за покупку ^_^";
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

        private void WorkWithBbAdd(Purchase purchase)
        {
            db.Purchases.Add(purchase);
            db.SaveChanges();
        }
    }
}