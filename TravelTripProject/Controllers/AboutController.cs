using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        TravelTripContext context = new TravelTripContext();
        public ActionResult Index()
        {
            var values = context.AboustUs.ToList();
            return View(values);
        }
    }
}