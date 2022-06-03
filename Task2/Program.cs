using System;

namespace Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var salary = new Salary(Console.ReadLine());
            salary.Taxes();

            // Comment for additional tax ideas
            // Higher paid individuals are considered those with 3000 and over monthly income
            // Higher paid individuals are required a tax of 25% to social contributions  
        }
    }
}
