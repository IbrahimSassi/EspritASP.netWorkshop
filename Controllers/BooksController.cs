using EspritASPWorkshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EspritASPWorkshop.Controllers
{
    public class BooksController : Controller
    {

        //Books
        static List<Book> Books;

        public BooksController()
        {
            Books = new List<Book>
            {
                new Book
                {
                    Id =1,
                    Title= "Book 1",
                    ISBN="45-5445-255"
                },
                new Book
                {
                    Id =2,
                    Title= "Book 2",
                    ISBN="12-5885-299"
                },
            };
        }

        // GET: Books
        public ActionResult Index()
        {
            return View(Books);
        }
    }
}