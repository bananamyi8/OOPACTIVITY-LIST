using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eighhteen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> originalWords = new List<string>();
            List<string> modifiedWords = new List<string>();

            Console.WriteLine("Enter words (type 'end' to finish):");

            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "end")
                    break;

                originalWords.Add(input);
                modifiedWords.Add(ReplaceVowels(input));
            }

            Console.WriteLine("\nOriginal\tModified");
            Console.WriteLine("-------------------------");
            for (int i = 0; i < originalWords.Count; i++)
            {
                Console.WriteLine($"{originalWords[i]}\t\t{modifiedWords[i]}");
            }
        }

        static string ReplaceVowels(string word)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            char[] chars = word.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (Array.Exists(vowels, v => v == Char.ToLower(chars[i])))
                {
                    chars[i] = '*';
                }
            }
            return new string(chars);
        }
    }
}
