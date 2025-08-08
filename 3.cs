using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THREELIST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> usernames = new List<string> { "Alice", "Bob", "Charlie", "David", "Eve" };

            Console.Write("Enter a character to search: ");
            string inputChar = Console.ReadLine().ToLower();

            Console.WriteLine("\nUsernames containing '" + inputChar + "':");

            bool found = false;
            foreach (string user in usernames)
            {
                if (user.ToLower().Contains(inputChar))
                {
                    Console.WriteLine(user);
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No usernames found containing '" + inputChar + "'.");
            }
        }
    }
}