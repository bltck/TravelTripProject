using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Classes
{
    public class Adress
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string FullAdress { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Location { get; set; }
    }
}