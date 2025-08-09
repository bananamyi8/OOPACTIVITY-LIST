using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIST20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> grades = new List<int>();
            int a = 0, b = 0, c = 0, d = 0, f = 0;

            Console.WriteLine("Enter 10 grades (0-100):");

            while (grades.Count < 10)
            {
                int grade;
                if (int.TryParse(Console.ReadLine(), out grade) && grade >= 0 && grade <= 100)
                {
                    grades.Add(grade);

                    int tens = grade / 10;
                    char letter;

                    switch (tens)
                    {
                        case 10:
                        case 9:
                            letter = 'A';
                            a++;
                            break;
                        case 8:
                            letter = 'B';
                            b++;
                            break;
                        case 7:
                            letter = 'C';
                            c++;
                            break;
                        case 6:
                            letter = 'D';
                            d++;
                            break;
                        default:
                            letter = 'F';
                            f++;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid grade. Enter a number between 0 and 100.");
                }
            }

            Console.WriteLine("\nGrade counts:");
            Console.WriteLine($"A: {a}");
            Console.WriteLine($"B: {b}");
            Console.WriteLine($"C: {c}");
            Console.WriteLine($"D: {d}");
            Console.WriteLine($"F: {f}");
        }
    }
}
