using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemoApp.Models
{
    public class RestaurantVM
    {
        public int Id { get; set; }
     
        public string Title { get; set; }

        public string City { get; set; }


        public double? AvgRating { get; set; }
    }
}