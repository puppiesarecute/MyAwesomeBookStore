using MyAwesomeBookStore.Models;
using MyAwesomeBookStore.Models.DataLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyAwesomeBookStore.Controllers
{
    public class BooksController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        // GET: Books
        public ActionResult TestIndex()
        {
            return View();
        }
    }
}