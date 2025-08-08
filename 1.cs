using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONELIST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var attendance = new List<string>();
            string name;

            Console.WriteLine("Enter student names (type 'done' to finish):");

            do
            {
                name = Console.ReadLine();
                if (name.ToLower() != "done")
                    attendance.Add(name.ToUpper());
            } while (name.ToLower() != "done");

            int countA = 0;
            Console.WriteLine("\nStudents Present:");

            foreach (var student in attendance)
            {
                Console.WriteLine(student);
                if (student.StartsWith("A"))
                    countA++;
            }

            Console.WriteLine($"\nNumber of names starting with 'A': {countA}");
        }
    }
}
