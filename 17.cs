using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sixteen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> uniqueWords = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            int totalSentences = 5;

            Console.WriteLine($"Enter {totalSentences} different sentences:");

            for (int i = 0; i < totalSentences; i++)
            {
                Console.Write($"Sentence #{i + 1}: ");
                string sentence = Console.ReadLine();

                // Split sentence into words
                string[] words = sentence.Split(new char[] { ' ', '.', ',', '!', '?', ';', ':', '-', '\"', '\'' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string word in words)
                {
                    uniqueWords.Add(word.ToLower());
                }
            }

            // Convert to list and sort
            List<string> sortedWords = new List<string>(uniqueWords);
            sortedWords.Sort();

            // Display results
            Console.WriteLine($"\nTotal unique words: {sortedWords.Count}");
            Console.WriteLine("Unique words (sorted):");
            foreach (var word in sortedWords)
            {
                Console.WriteLine(word);
            }
    }
}
