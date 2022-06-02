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

        public string ToResult()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{Name} {Surname}");
            sb.AppendLine($"{Sex}");
            sb.AppendLine($"{Nationality}");
            sb.AppendLine($"{GetAge()} years old");
            return sb.ToString();
        }

        public int GetAge()
        {
            var now =  DateTime.UtcNow;
            int age = DateTime.Now.Year - DateOfBirth.Year;

            if (now.Month < DateOfBirth.Month || (now.Month == DateOfBirth.Month && now.Day < DateOfBirth.Day))
                age--;

            return age;
        }

    }
}
