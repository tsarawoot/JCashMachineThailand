using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JCashMachineThailand.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Content creation by View";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Content creation by View";

            return View();
        }
    }
}