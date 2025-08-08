using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NINELIST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> formattedNames = new List<string>();

            Console.WriteLine("Enter 6 full names:");

            for (int i = 0; i < 6; i++)
            {
                Console.Write($"Name {i + 1}: ");
                string input = Console.ReadLine().ToLower();
                string[] parts = input.Split(' ');
                string formatted = "";

                foreach (string part in parts)
                {
                    if (part.Length > 0)
                    {
                        string capitalized = part.Substring(0, 1).ToUpper() + part.Substring(1);
                        formatted += capitalized + " ";
                    }
                }

                formattedNames.Add(formatted.Trim());
            }

            Console.WriteLine("\nFormatted Names:");
            foreach (string name in formattedNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}