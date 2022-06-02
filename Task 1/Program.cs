using System;
using System.IO;
using Newtonsoft;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("Text\\input.txt");
            Console.WriteLine(text);
        }
    }
}
