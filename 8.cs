using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIGHTLIST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            Console.WriteLine("Enter 10 numbers:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Number {i + 1}: ");
                int input = int.Parse(Console.ReadLine());
                numbers.Add(input);
            }

            List<int> filteredNumbers = numbers.Where(n => n > 50).ToList();

            Console.WriteLine($"\nOriginal count: {numbers.Count}");
            Console.WriteLine($"Filtered count (numbers > 50): {filteredNumbers.Count}");


            Console.WriteLine("Filtered numbers:");
            foreach (int num in filteredNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
