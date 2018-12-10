using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Word_Frequency
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the text with seperators like gap and dot.");
            string text = Console.ReadLine();

            var wordFrequencyCount = new Dictionary<string, int>();
            var words = text.Split(' ', '.').Where(x => x.Length > 0);

            foreach (var word in words)
            {
                if (!wordFrequencyCount.ContainsKey(word))
                {
                    wordFrequencyCount.Add(word, 1);
                }
                else
                {
                    wordFrequencyCount[word]++;
                }
            }

            Console.WriteLine("Words frequency:\n");

            foreach (var word in wordFrequencyCount)
            {
                Console.WriteLine("{0} - {1} times", word.Key, word.Value);
            }
        }
    }
}