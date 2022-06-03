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
            SocialContributing();

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
            Console.WriteLine($"Income above threshold, 10% tax = {Tax} IDR");
            income -= Tax;
        }
        private void SocialContributing()
        {
            if (income - 1000 > 3000)
            {
                return;
            }
            SocialContribution = (income - baseIncome) * 0.15;
            Console.WriteLine($"Social contribution of 15% = {SocialContribution} IDR");
            income -= SocialContribution;

        }
    }
}
