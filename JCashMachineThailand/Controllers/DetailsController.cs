using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using JCashMachineThailand.Models;

namespace JCashMachineThailand.Controllers
{
    public class DetailsController : Controller
    {
        //created details information
        ModelDetails details = new ModelDetails();

        // GET: Products
        public ActionResult Products()
        {
            List<Product> products = details.GetProducts();
            return View(products);
        }

        // GET: Service
        public ActionResult Service()
        {
            List<Service> services = details.GetServices();
            return View(services);
        }

        // GET: Career
        public ActionResult Career()
        {
            return View();
        }

    }
}