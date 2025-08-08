using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIVELIST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> grades = new List<int>();
            int countA = 0, countB = 0, countC = 0, countD = 0, countF = 0;

            Console.WriteLine("Enter 7 student grades (0–100):");

            while (grades.Count < 7)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out int grade) && grade >= 0 && grade <= 100)
                {
                    grades.Add(grade);

                    switch (grade / 10)
                    {
                        case 10:
                        case 9:
                            countA++;
                            break;
                        case 8:
                            countB++;
                            break;
                        case 7:
                            countC++;
                            break;
                        case 6:
                            countD++;
                            break;
                        default:
                            countF++;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Enter a number from 0 to 100.");
                }
            }
            Console.WriteLine("A: " + countA);
            Console.WriteLine("B: " + countB);
            Console.WriteLine("C: " + countC);
            Console.WriteLine("D: " + countD);
            Console.WriteLine("F: " + countF);
        }
    }
}