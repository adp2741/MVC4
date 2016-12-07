using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVC4.Models;
using System.Collections.Generic;

namespace MVC4.Tests.Features
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var data = new Restaurant();
            data.Reviews = new List<RestaurantReview>();
            data.Reviews.Add(new RestaurantReview() { Rating = 4 });

            var rater = new RestaurantRater(data);
            var result = rater.ComputRating(10);

            Assert.AreEqual(4, result.Rating);
        }
    }
}
