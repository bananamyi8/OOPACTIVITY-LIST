using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIST11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            List<float> salaries = new List<float>();

            Console.WriteLine("Enter number of employees:");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.Write($"Enter name of employee #{i + 1}: ");
                names.Add(Console.ReadLine());

                Console.Write($"Enter salary of employee #{i + 1}: ");
                salaries.Add(float.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < count; i++)
            {
                if (salaries[i] < 15000)
                    salaries[i] *= 1.05f;
                else if (salaries[i] <= 30000)
                    salaries[i] *= 1.03f;
            }

            Console.WriteLine("\nAdjusted Salaries:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{names[i]}: {salaries[i]:F2}");
            }

            Console.WriteLine("\nEmployees earning above 25,000 after adjustment:");
            for (int i = 0; i < count; i++)
            {
                if (salaries[i] > 25000)
                    Console.WriteLine($"{names[i]}: {salaries[i]:F2}");
            }
        }
    }
}
