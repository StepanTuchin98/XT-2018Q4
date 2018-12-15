using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.StudentPractice.Lection2.Task10._2D_Array
{
    class Program
    {
        const int Length = 10;

        static void Main(string[] args)
        {
            double[,] mas = GenerateMas();
            double sum = GetSum(mas);
            Console.WriteLine($"Summary of numbers with even positions: {sum}");
            Show(mas);
        }


        public static double[,] GenerateMas()
        {
            double[,] tmp = new double[Length, Length];
            Random r = new Random();
            for (int i = 0; i < tmp.GetLength(0); i++)
            {
                for (int j = 0; j < tmp.GetLength(1); j++)
                {
                    tmp[i, j] = r.Next(100);
                }
            }
            return tmp;
        }

        public static double GetSum(double[,] mas)
        {
            double sum = 0;

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if ((i + j)  % 2 == 0)
                    {
                        sum += mas[i, j];
                    }
                }
            }

            return sum;
        }

        public static void Show(double[,] mas)
        {
            foreach (var item in mas)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }
    }
}

