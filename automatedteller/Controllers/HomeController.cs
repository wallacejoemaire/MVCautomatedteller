using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace automatedteller.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page is great.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Foo()
        {
            return View("About");
        }

        public ActionResult Serial(string lettercase)
        {
            var serial = "ASPNETMVC5ATM1";

            if (lettercase == "lower")            {
                return Content(serial.ToLower());
            }
            return Content(serial);
        }
    }
}