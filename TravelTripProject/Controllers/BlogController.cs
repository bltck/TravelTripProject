using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    public class BlogController : Controller
    {
        // GET: BlogController
        TravelTripContext context = new TravelTripContext();
        BlogComment blogComment = new BlogComment();
        public ActionResult Index()
        {
            //var blogs = context.Blogs.ToList();
            blogComment.blog = context.Blogs.ToList();
            blogComment.recentBlog = context.Blogs.OrderByDescending(x => x.Id).Take(3).ToList();
            return View(blogComment);
        }
        public ActionResult BlogDetails(int Id)
        {
            //var findBlog = context.Blogs.Where(b => b.Id == Id).ToList();
            blogComment.blog= context.Blogs.Where(b => b.Id == Id).ToList();
            blogComment.comment = context.Comments.Where(b => b.BlogId == Id).ToList();
            return View(blogComment);
        }
    }
}