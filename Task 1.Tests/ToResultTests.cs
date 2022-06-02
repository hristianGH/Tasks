using System;
using Task_1.Models;
using Xunit;

namespace Task_1.Tests
{
    public class ToResultTests
    {
        [Fact]
        public void ToResultShouldReturnStringWithValue()
        {
            var star = new MovieStar()
            {
                Name = "Jon",
                Surname = "Snow",
                DateOfBirth = new DateTime(1000, 3, 22),
                Nationality = "unknown",
                Sex = "Male"
            };
            var result = star.ToResult();
            Assert.NotEmpty(result);
        }
    }
}
