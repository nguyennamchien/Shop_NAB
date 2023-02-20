using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop_NAB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Hello bạn đây là shop của tuiiii.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Hãy gọi cho tôi đi mà ";
            ViewBag.Message = "Phone : 087425401";



            return View();
        }
    }

}