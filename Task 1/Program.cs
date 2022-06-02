using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Task_1.Models;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("Text\\input.txt");
            var deserialize =JsonConvert.DeserializeObject<List<MovieStar>>(text);
            foreach (var item in deserialize)
            {
                Console.WriteLine(item.ToResult());
            }
        }
    }
}
