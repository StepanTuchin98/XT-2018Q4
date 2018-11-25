using Epam.StudentPractice.Lection2.Task7.Array_Processing;
using System;

namespace Epam.StudentPractice.Lection2.Task9.Non_Negative_Sum
{
    class Program
    {
        const int Length = 10;
        static void Main(string[] args)
        {
            double[] mas = GenerateMas();
            Console.WriteLine("Massive");
            Show(mas);
            GetCountNonNegative(mas);

        }

        public static double[] GenerateMas()
        {
            double[] tmp = new double[Length];
            Random r = new Random();
            for (int i = 0; i < Length; i++)
            {
                tmp[i] = r.Next(100);
            }
            return tmp;
        }
        public static void Show(double[] mas)
        {
            foreach (var item in mas)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }

        public static double GetCountNonNegative(double[] mas)
        {
            double sum = 0;
            foreach (var item in mas)
            {
                if( item > 0)
                {
                    sum += item;
                }
            }
            return sum;
        }
    }
}
