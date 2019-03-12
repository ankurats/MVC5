namespace MVCDemoApp.Migrations
{
    using MVCDemoApp.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCDemoApp.Models.RestaurantAppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MVCDemoApp.Models.RestaurantAppContext context)
        {
            Restaurant[] arr = new Restaurant[]
            {
                new Restaurant{Id=1, Title="Mogli", City="Noida"},
                new Restaurant{Id=2, Title="YoChina", City="Delhi"},

                new Restaurant{Id=3, Title="Haldiram", City="Noida"}
            };

            Review[] review = new Review[]
            {
                new Review{Id=1, Comment="Good Food", Rating=5, Restaurant= arr[0]},
                new Review{Id=2, Comment="Tasty Food", Rating=4, Restaurant= arr[0]},
                new Review{Id=3, Comment="Good Food", Rating=3, Restaurant= arr[0]},
                new Review{Id=4, Comment="Good Service", Rating=5, Restaurant= arr[1]},
                new Review{Id=5, Comment="Good Food", Rating=4, Restaurant= arr[1]},
                new Review{Id=6, Comment="Good Parking", Rating=5, Restaurant= arr[1]},
                new Review{Id=7, Comment="Good Food", Rating=5, Restaurant= arr[2]},
                new Review{Id=8, Comment="Good servcie", Rating=5, Restaurant= arr[2]},

                new Review{Id=9, Comment="Good Food", Rating=5, Restaurant= arr[2]},
            };

            context.Reviews.AddOrUpdate(review);
            context.SaveChanges();
        }
    }
}
