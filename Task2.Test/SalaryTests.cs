using System;
using Xunit;

namespace Task2.Test
{
    public class SalaryTests
    {
        [Fact]
        public void SalaryBellow1000ShouldNotApplyTaxes()
        {
            string input = "1000";
            var salary = new Salary(input);
            salary.Taxes();
            Assert.True(salary.Income == 1000);
        }

        [Fact]
        public void SalaryAbove1000ShouldApplyTaxes()
        {
            string input = "1100";
            var salary = new Salary(input);
            salary.Taxes();
            Assert.True(salary.Income != 1000);
        }

        [Fact]
        public void SalaryConstructorShouldNotWorkWithNegativeStringValues()
        {
            string input = "-1100";
            var salary = new Salary(input);
            salary.Taxes();
            Assert.True(!salary.SalaryIsValid);
        }
        [Fact]
        public void SalaryConstructorShouldNotWorkWithNegativeValues()
        {
            double input = -1100;
            var salary = new Salary(input);
            salary.Taxes();
            Assert.True(!salary.SalaryIsValid);
        }

        [Fact]
        public void SalaryConstructorShouldNotWorkWithNonNumericValues()
        {
            string input = "Test";
            var salary = new Salary(input);
            salary.Taxes();
            Assert.True(!salary.SalaryIsValid);
        }

        [Fact]
        public void SalarySocialContributingShouldNotApplyToIncomeOver3000()
        {
            double input = 5000;
            var salary = new Salary(input);
            salary.Taxes();
            Assert.True(salary.SocialContribution==0);
        }
    }
}
