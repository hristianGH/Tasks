using System;
using System.Text;

namespace Task_1.Models
{
    public class MovieStar
    {
        public DateTime DateOfBirth { get; set;}
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Sex { get; set; }
        public string Nationality { get; set; }


        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{Name} {Surname}");
            sb.AppendLine($"{Sex}");
            sb.AppendLine($"{Nationality}");
            sb.AppendLine($"{DateOfBirth}");
            return sb.ToString();
        }

    }

    
}
