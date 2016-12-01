namespace MVC4.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVC4.Models.MVC4Db>
    {
        public Configuration()
        {
            AutomaticMigrationDataLossAllowed = true;
            AutomaticMigrationsEnabled = true;
            ContextKey = "MVC4.Models.MVC4Db";
        }

        protected override void Seed(MVC4.Models.MVC4Db context)
        {
            context.Restaurants.AddOrUpdate(r => r.Name,
                new Restaurant { Name = "Sabatino's", City = "Baltimore", Country = "USA" },
                new Restaurant { Name = "Great Lake", City = "Chicago", Country = "USA" },
                new Restaurant
                {
                    Name = "Smaka",
                    City = "Gothenburg",
                    Country = "Sweden",
                    Reviews =
                        new List<RestaurantReview>
                        {
                            new RestaurantReview { Rating = 9, Body = "Great food!", ReviewerName = "Andrew Perry" }
                        }
                });
            for (int i = 0; i < 1000; ++i)
            {
                context.Restaurants.AddOrUpdate(r => r.Name,
                    new Restaurant { Name = i.ToString(), City = "Nowhere", Country = "USA" });
            }
        }
    }
}
