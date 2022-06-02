using System;

namespace Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            double salary = 0;
            double tax = 0;
            double socialContribution = 0;


            //Check if input is valid
            if (!double.TryParse(Console.ReadLine(), out salary) || salary < 0)
            {
                Console.WriteLine("Invalid value !");
                return;
            }

            //Check amount lower than 1000
            if (salary <= 1000)
            {
                Console.WriteLine("Income below threshold, no tax");
                return;
            }

            tax = (salary - 1000) * 0.10;
            Console.WriteLine($"Income above threshold, 10% tax = {tax} IDR");
            salary -= tax;

            //Social Contributions 
            if (salary-1000 <= 3000)
            {
                socialContribution = (salary - 1000) * 0.15;
                Console.WriteLine($"Social contribution of 15% = {socialContribution} IDR");
                salary -= socialContribution;
            }
            Console.WriteLine($"Total tax = {tax + socialContribution}");
            Console.WriteLine($"Income is {salary}");

            //Comment for additional taxes 
            //Higher paid individuals are required a tax of 25% to social contributions  
            //Higher paid individuals are considered those with 3000 and over monthly income
        }
    }
}
