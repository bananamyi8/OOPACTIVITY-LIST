using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIXLIST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>();

            Console.WriteLine("Enter city names (type 'exit' to finish):");

            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "exit")
                    break;
                cities.Add(input);
            }

            List<string> uniqueCities = cities.Distinct().ToList();
            uniqueCities.Sort();

            Console.WriteLine("\n--- City List (Alphabetical, No Duplicates) ---");
            foreach (string city in uniqueCities)
            {
                Console.WriteLine(city);
            }
        }
    }
}
