using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookManager.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }




        public ActionResult About()
        {
            ViewBag.Message = "YOUR Application Description Page.";

            return View();
        }
          



        public ActionResult Contact()
        {
            ViewBag.Message = "Your Contact PAGE.";
            return View();
        }
    }
}