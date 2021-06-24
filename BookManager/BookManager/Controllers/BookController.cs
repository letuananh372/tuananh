using BookManager.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookManager.Controllers
{
    public class BookController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListBook()
        {
            BookManagerContext context = new BookManagerContext();
            var listBook = context.Books.ToList();
            return View(listBook);
        }

        [Authorize]
        public ActionResult Buy(int id)
        {
            BookManagerContext context = new BookManagerContext();
            Book book = context.Books.SingleOrDefault(p => p.ID == id);
            if(book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }
        public ActionResult CreateBook()
        {
            
            return View();
        }
        [HttpPost, ActionName("CREATEBOOK")]
        [ValidateAntiForgeryToken]
        public ActionResult Contact(int id)
        {
            BookManagerContext context = new BookManagerContext();
            Book book = context.Books.SingleOrDefault(p => p.ID == id);
            var books = new List<Book>();
            try
            {
                if (ModelState.IsValid)
                {
                    books.Add(book);
                }
            }
            catch (RetryLimitExceededException)
            {
                ModelState.AddModelError("", "EROROR SAVE DATA");
            }
            return View("ListBookModel", books);
        }
         public ActionResult EditBook(int id)
         {
            BookManagerContext context = new BookManagerContext();
            Book book = context.Books.SingleOrDefault(p => p.ID == id);
            var books = new List<Book>();
            if (book != null)
            {
                context.Books.AddOrUpdate(book); 
                context.SaveChanges();
            }
            
            return View(book);
        }
        public ActionResult DeleteBook(int id)
        {
            BookManagerContext context = new BookManagerContext();
            Book book = context.Books.SingleOrDefault(p => p.ID == id);
            var books = new List<Book>();
            if (book != null)
            {
                context.Books.Remove(book);
                context.SaveChanges();
                
            }
            return View(book);
        }
       
    }
}