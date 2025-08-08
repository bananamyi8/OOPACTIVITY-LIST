using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWELVELIST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> productNames = new List<string>();
            List<int> stockCounts = new List<int>();

            Console.WriteLine("Enter 10 product names and their stock counts:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Product {i + 1} name: ");
                string name = Console.ReadLine();
                productNames.Add(name);

                Console.Write($"Stock count for {name}: ");
                int count = int.Parse(Console.ReadLine());
                stockCounts.Add(count);
            }

            Console.WriteLine("\nRestocked Items:");
            for (int i = 0; i < 10; i++)
            {
                if (stockCounts[i] < 10)
                {
                    stockCounts[i] += 20;
                    Console.WriteLine($"{productNames[i]} was restocked. New stock: {stockCounts[i]}");
                }
            }

            Console.WriteLine("\nFinal Stock Levels:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{productNames[i]}: {stockCounts[i]}");
            }
        }
    }
}
