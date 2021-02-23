using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Classes
{
    public class BlogComment
    {
        public IEnumerable<Blog> blog { get; set; }
        public IEnumerable<Blog> recentBlog { get; set; }
        public IEnumerable<Comment> comment { get; set; }
    }
}