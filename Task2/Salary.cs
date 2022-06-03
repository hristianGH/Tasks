using System;

namespace Task2
{
    public class Salary
    {
        private bool salaryIsValid = true;
        private double income;
        private double baseIncome = 1000;

        public Salary(double salary)
        {
            // Check if input is valid
            if (salary < 0)
            {
                salaryIsValid = false;
                return;
            }
            this.income = salary;

        }
        public Salary(string salaryConsole)
        {
            // Check if input is valid
            double salary = 0;
            bool isValid = double.TryParse(salaryConsole, out salary);

            if (salary < 0 || !isValid)
            {
                Console.WriteLine("Invalid value !");
                salaryIsValid = false;
                return;
            }
            this.income = salary;
        }

        public double Income { get { return this.income; } }
        public bool SalaryIsValid { get { return this.salaryIsValid; } }

        public double Tax { get; set; }
        public double SocialContribution { get; set; }

        public void Taxes()
        {
            if (!salaryIsValid)
            {
                return;
            }
            ApplyTax();

            Console.WriteLine($"Total tax = {Tax + SocialContribution}");
            Console.WriteLine($"Income is {income}");
        }

        private void ApplyTax()
        {
            // Check amount lower than 1000
            if (income <= baseIncome)
            {
                Console.WriteLine("Income below threshold, no tax");
                return;
            }

            Tax = (income - baseIncome) * 0.10;
            Console.WriteLine($"Income above threshold, 10% tax from {income} = {Tax} IDR");
            income -= Tax;
            SocialContributing();

        }

        private void SocialContributing()
        {
            double diffrence = 0;
            if (income > 3000)
            {
                diffrence = Math.Abs(income - 3000);
            }

            SocialContribution = (income - diffrence - baseIncome) * 0.15;
            Console.WriteLine($"Social contribution of 15% from {income - diffrence - baseIncome} = {SocialContribution} IDR");
            income -= SocialContribution;
        }
    }
}
