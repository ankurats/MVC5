using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCDemoApp.Models
{
    public class RestaurantAppContext : DbContext
    {
        public RestaurantAppContext()
        {

        }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}