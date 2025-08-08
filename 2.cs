using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWOLIST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<decimal> prices = new List<decimal>();
            decimal input;

            Console.WriteLine("Enter item prices (type -1 to finish):");

            while (true)
            {
                if (!decimal.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Invalid input. Please enter a decimal number.");
                    continue;
                }

                if (input == -1)
                    break;

                if (input < 0)
                {
                    Console.WriteLine("Price cannot be negative. Try again.");
                    continue;
                }

                prices.Add(input);
            }

            if (prices.Count == 0)
            {
                Console.WriteLine("No prices entered.");
                return;
            }

            Console.WriteLine($"Total items: {prices.Count}");
            Console.WriteLine($"Average price: {prices.Average():C}");
            Console.WriteLine($"Highest price: {prices.Max():C}");
            Console.WriteLine($"Lowest price: {prices.Min():C}");
        }
    }
}
