using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEVENLIST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> products = new List<string>();

            Console.WriteLine("Enter 8 product names:");
            for (int i = 0; i < 8; i++)
            {
                Console.Write($"Product {i + 1}: ");
                string product = Console.ReadLine();
                products.Add(product);
            }

            Console.Write("\nEnter a keyword to search: ");
            string keyword = Console.ReadLine().ToLower();

            List<string> matches = new List<string>();

            foreach (string product in products)
            {
                if (product.ToLower().Contains(keyword))
                {
                    matches.Add(product);
                }
            }

            Console.WriteLine("\nSearch Results:");
            if (matches.Count > 0)
            {
                foreach (string match in matches)
                {
                    Console.WriteLine("- " + match);
                }
            }
            else
            {
                Console.WriteLine("No products found.");
            }
        }
    }
}