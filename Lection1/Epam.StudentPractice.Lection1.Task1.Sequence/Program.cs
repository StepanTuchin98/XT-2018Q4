using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.StudentPractice.Lection1.Task1.Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This app will show you a sequence.");
            Console.Write("Enter the number of the digits (positive number)");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                if (n > 0)
                {
                    GetSequence(n);
                }
                else
                {
                    Console.WriteLine("Enter a number above 0 next time!");
                }
            }
            else
            {
                Console.WriteLine("Enter a number next time!");
            }
        }

        public static void GetSequence(int n)
        {
            Console.Write("Your sequance: ");
            for (int i = 1; i < n; i++)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine(n);
            /* 
            List<int> t = new List<int>(); 
            for (int i = 1; i <= n; i++) 
            t.Add(i); 

            String rs = String.Join(",", t.ToArray()); 
            return rs;*/
        }
    }
}
