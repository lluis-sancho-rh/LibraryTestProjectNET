using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            var author = db.Authors.OrderBy(r => Guid.NewGuid()).Take(1).ToList();
            ViewBag.author = author.First();

            var books = db.Books.OrderBy(r => Guid.NewGuid()).Take(3).ToList();
            ViewBag.books = books;

            return View();
        }        
    }
}