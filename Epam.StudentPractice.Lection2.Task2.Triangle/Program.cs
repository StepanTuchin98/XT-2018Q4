using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.StudentPractice.Lection2.Task2.Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This app draws a rectangle.");
            Console.Write("Enter rectangle's side (positive number)");

            int n;

            while (true)
            {
                if(int.TryParse(Console.ReadLine(), out n))
                {
                    if(n < 1)
                    {
                        Console.WriteLine("Enter valid number.");
                    }
                    else
                    {
                        break;
                    }
                }
            }

            DrawRectangle(n);
        }
        public static void DrawRectangle(int n)
        {
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < i + 1 ; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
