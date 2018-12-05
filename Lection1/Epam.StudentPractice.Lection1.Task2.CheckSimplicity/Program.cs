using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.StudentPractice.Lection1.Task2.CheckSimplicity
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result;
            Console.WriteLine("This app will check, if number is simple.");
            Console.Write("Enter the number to check it! (positive number)");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                if (n > 0)
                {
                    result = IsSimple(n);
                    Console.WriteLine($"The number is simple: {result}");
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

        public static bool IsSimple(int n)
        {
            //All dividers can be search by point of sqrt(number)
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
