using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        TravelTripContext context = new TravelTripContext();
        public ActionResult Index()
        {
            var values = context.Blogs.Take(4).ToList();
            return View(values);
        }
        public ActionResult About()
        {
            return View();
        }
        public PartialViewResult Partial1()
        {
            var values = context.Blogs.OrderByDescending(x => x.Id).Take(2).ToList();
            return PartialView(values);
        }
        public PartialViewResult Partial2()
        {
            var values = context.Blogs.Where(x=>x.Id==1).Take(2).ToList();
            return PartialView(values);
        }
        public PartialViewResult Partial3()
        {
            var values = context.Blogs.ToList();
            return PartialView(values);
        }
    }
}