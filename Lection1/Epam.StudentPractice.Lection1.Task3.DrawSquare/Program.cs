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
            int n;
            Console.WriteLine("This app will show you a square of the stars.");

            do
            {
                Console.Write("Enter positive not even number (number of lines)");
                int.TryParse(Console.ReadLine(), out n);
            }
            while (n % 2 != 0 && n < 1);

            ShowStarsCube(n);
        }
        public static void ShowStarsCube(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
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
