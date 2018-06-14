using AjaxLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxLab.Controllers
{
    public class HomeController : Controller
    {
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


        [HttpPost]
        public ActionResult GetAuthor(string author)
        {
            LibraryEntities db = new LibraryEntities();


            List<book> list = db.books.Where(
               c => c.Author.Contains(author)
                ).ToList();

            return Json(list);
        }

        [HttpPost]
        public ActionResult GetTitle(string title)
        {
            LibraryEntities db = new LibraryEntities();


            List<book> list = db.books.Where(
               c => c.Title.Contains(title)
                ).ToList();

            return Json(list);
        }

        [HttpPost]
        public ActionResult GetYear(int? year)
        {
            LibraryEntities db = new LibraryEntities();


            List<book> list = db.books.Where(
               c => c.YearPublished == year
                ).ToList();

            return Json(list);
        }
    }
}