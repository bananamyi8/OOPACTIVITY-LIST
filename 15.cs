using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIXTEENLIST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> registeredCourses = new List<string>();
            int maxCourses = 6;

            Console.WriteLine($"Register up to {maxCourses} courses (each code exactly 5 characters):");

            while (registeredCourses.Count < maxCourses)
            {
                Console.Write($"Enter course code #{registeredCourses.Count + 1}: ");
                string code = Console.ReadLine();

                if (code.Length != 5)
                {
                    Console.WriteLine("Error: Course code must be exactly 5 characters long.");
                    continue;
                }

                if (registeredCourses.Contains(code))
                {
                    Console.WriteLine("Error: Duplicate course code entered.");
                    continue;
                }

                registeredCourses.Add(code);
                Console.WriteLine($"Success: Course '{code}' registered.");
            }

            Console.WriteLine("\nAll registered courses:");
            foreach (var course in registeredCourses)
            {
                Console.WriteLine(course);
            }
        }
    }
}
