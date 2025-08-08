using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOURTEENLIST
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> countries = new List<string> {
                "Manila", "Tokyo", "Paris", "Ottawa", "Brasilia",
                "Canberra", "New Delhi", "Berlin", "Cairo", "Mexico City"};
            List<string> capitals = new List<string> {
                "Philippines", "Japan", "France", "Canada", "Brazil",
                "Australia", "India", "Germany", "Egypt", "Mexico"};

            Console.Write("Enter a country name: ");
            string inputCountry = Console.ReadLine();

            bool found = false;
            for (int i = 0; i < countries.Count; i++)
            {
                if (countries[i].ToLower() == inputCountry.ToLower())
                {
                    Console.WriteLine($"The capital of {countries[i]} is {capitals[i]}.");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Country not found.");
            }
        }
    }
}