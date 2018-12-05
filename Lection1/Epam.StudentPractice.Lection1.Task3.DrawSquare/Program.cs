using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.StudentPractice.Lection1.Task3.DrawSquare
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This app will show you a square of the stars.");
            Console.Write("Enter positive not even number (number of lines)");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                if (n % 2 != 0 && n > 0)
                {
                    ShowStarsCube(n);
                }
                else
                {
                    Console.WriteLine("The number must be above zero and odd!");
                }
            }
            else
            {
                Console.WriteLine("Enter a number next time!");
            }
        }
        public static void ShowStarsCube(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    //Check center of the square
                    if (!(i == n / 2 + 1 && j == n / 2 + 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
        }

    }
}
