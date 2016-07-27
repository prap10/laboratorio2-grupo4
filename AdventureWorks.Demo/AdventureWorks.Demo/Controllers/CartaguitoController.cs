using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdventureWorks.Demo.Controllers
{
    public class CartaguitoController : Controller
    {
        // GET: Cartaguito
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Campeon()
        {
            ViewBag.Message = "Al fin campeones";
            return View();
        }
    }
}