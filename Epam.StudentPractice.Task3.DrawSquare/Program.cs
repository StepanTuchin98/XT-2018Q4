using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.StudentPractice.Task3.DrawSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int N = int.Parse(Console.ReadLine());
            if (N % 2 != 0)
            ShowStarsCube(N);
            else
                Console.WriteLine("Even number");
        }
        public static void ShowStarsCube(int N)
        {
            for (int i = 1; i <= N; i++)
            {

                for (int j = 1; j <= N; j++)
                    if (!(i == N / 2 + 1 && j == N / 2 + 1))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                Console.WriteLine();
            }


        }

    }
}
