using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _199
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> attendees = new List<string>();

            Console.WriteLine("Enter student names logging in (type 'end' to finish):");

            while (true)
            {
                string name = Console.ReadLine();
                if (name.ToLower() == "end")
                    break;

                if (!attendees.Contains(name, StringComparer.OrdinalIgnoreCase))
                {
                    attendees.Add(name);
                    Console.WriteLine($"{name} logged in.");
                }
                else
                {
                    Console.WriteLine($"{name} already logged in. Ignoring duplicate.");
                }
            }

            attendees.Sort(StringComparer.OrdinalIgnoreCase);

            Console.WriteLine($"\nTotal unique attendees: {attendees.Count}");
            Console.WriteLine("List of attendees:");
            foreach (var attendee in attendees)
            {
                Console.WriteLine(attendee);
            }
        }
    }
}
