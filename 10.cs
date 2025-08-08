using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TENLIST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = new List<int>();
            List<int> evenList = new List<int>();
            List<int> oddList = new List<int>();

            Console.WriteLine("Enter 12 numbers:");

            for (int i = 0; i < 12; i++)
            {
                Console.Write($"Number {i + 1}: ");
                int num = int.Parse(Console.ReadLine());
                inputList.Add(num);

                if (num % 2 == 0)
                {
                    evenList.Add(num);
                }
                else
                {
                    oddList.Add(num);
                }
            }

            Console.WriteLine("\nEven Numbers:");
            foreach (int num in evenList)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("\n\nOdd Numbers:");
            foreach (int num in oddList)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n\nOriginal Input List:");
            foreach (int num in inputList)
            {
                Console.Write(num + " ");
            }
        }
    }
}
