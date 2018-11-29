using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.StudentPractice.Lection2.Task3.AnotherTriangle
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
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    if (n < 1)
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
            for (int i = 0; i < n; i++)
            {
                for (int j = n; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("*");
                    if(k > 0)
                        Console.Write("*");

                }
                Console.WriteLine();
            }
        }
    }
}
