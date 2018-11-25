using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.StudentPractice.Lection2.Task4.X_mas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This app draws a xmas tree.");
            Console.Write("Enter number of triangles (positive number)");

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
            for(int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    for(int k = 0; k < n - j; k++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < j; k++)
                    {
                        Console.Write("*");
                        if (k > 0)
                            Console.Write("*");
                    }
                    if(i != j)
                    Console.WriteLine();

                }
            }
            Console.WriteLine();
        }

    }
}
