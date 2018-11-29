using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.StudentPractice.Lection2.Task11.AverageStringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"This app counts average length of the words.{Environment.NewLine}Enter your string!");

            string s = Console.ReadLine();

            int firstPos = 0;
            bool isLetter = false;
            int sum = 0, amount = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetter(s[i]))
                {
                    if (!isLetter)
                    {
                        firstPos = i;
                        isLetter = true;
                    }
                }
                else
                {
                    if (isLetter)
                    {
                        amount++;
                        sum += i - firstPos;
                        isLetter = false;
                    }
                }
            }
          
            if (isLetter)
            {
                amount++;
                sum += s.Length - firstPos;
            }
            double result = sum / amount;
            Console.WriteLine($"Average length of the strings: {result}");
        }
    }
}
