using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOURLIST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> birthYears = new List<string>();
            int currentYear = DateTime.Now.Year;

            Console.WriteLine("Enter 5 birth years:");

            while (birthYears.Count < 5)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int year))
                {
                    birthYears.Add(input);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a numeric year.");
                }
            }

            foreach (string yearStr in birthYears)
            {
                int year = Convert.ToInt32(yearStr);
                int age = currentYear - year;
                string status;

                if (age < 18)
                    status = "Minor";
                else if (age < 60)
                    status = "Adult";
                else
                    status = "Senior";

                Console.WriteLine($"Birth Year: {year} → Age: {age} → {status}");
            }
        }
    }
}
