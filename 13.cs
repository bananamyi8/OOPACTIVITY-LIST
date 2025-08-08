using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THIRTEENLIST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> studentNames = new List<string>();
            List<int> studentScores = new List<int>();

            Console.WriteLine("Enter a student name and their quiz scores:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Student {i + 1} name: ");
                studentNames.Add(Console.ReadLine());

                Console.Write($"Score for {studentNames[i]}: ");
                studentScores.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < studentScores.Count - 1; i++)
            {
                for (int j = 0; j < studentScores.Count - i - 1; j++)
                {
                    if (studentScores[j] < studentScores[j + 1])
                    {
                        int tempScore = studentScores[j];
                        studentScores[j] = studentScores[j + 1];
                        studentScores[j + 1] = tempScore;

                        string tempName = studentNames[j];
                        studentNames[j] = studentNames[j + 1];
                        studentNames[j + 1] = tempName;
                    }
                }
            }

            Console.WriteLine("\nTop 3 Performers:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{i + 1}. {studentNames[i]} - {studentScores[i]}");
            }
        }
    }
}
