using System;
using Task_1.Models;
using Xunit;

namespace Task_1.Tests
{
    public class AgeTests
    {
        [Fact]
        public void GetAgeShouldReturnValue()
        {
            var star = new MovieStar()
            {
                Name = "Jon",
                Surname = "Snow",
                DateOfBirth = new DateTime(1000, 3, 22),
                Nationality ="unknown",
                Sex="Male"
            };
            var result = star.GetAge();
            Assert.True(result > 0);
        }

        [Fact]
        public void GetAgeShouldCheckMonthAndDateDiffrence()
        {
            var now = DateTime.Now;
            var star = new MovieStar()
            {
                Name = "Some",
                Surname = "Kid",
                DateOfBirth = new DateTime(now.Year - 5, now.Month+1, now.Day),
                Nationality = "unknown",
                Sex = "Dunno"
            };
            var result = star.GetAge();
            Assert.True(result == 4);
            star = new MovieStar()
            {
                Name = "Other",
                Surname = "Kid",
                DateOfBirth = new DateTime(now.Year - 5, now.Month, now.Day+1),
                Nationality = "unknown",
                Sex = "Dunno"
            };
        }
    }
}
