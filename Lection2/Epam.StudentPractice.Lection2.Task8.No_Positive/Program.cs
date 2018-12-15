using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.StudentPractice.Lection2.Task8.No_Positive
{
    class Program
    {
        const int Length = 2;

        static void Main(string[] args)
        {
            double[,,] mas = GenerateMas();
            Show(mas);
            SetNoPositive(ref mas);
            Show(mas);
        }


        public static double[,,] GenerateMas()
        {
            double[,,] tmp = new double[Length, Length, Length];
            Random r = new Random();
            for (int i = 0; i < tmp.GetLength(0); i++)
            {
                for (int j = 0; j < tmp.GetLength(1); j++)
                {
                    for (int k = 0; k < tmp.GetLength(2); k++)
                    {
                        tmp[i, j, k] = r.Next(-100,100);
                    }
                }
            }
            return tmp;
        }

        public static void SetNoPositive(ref double[,,] mas)
        {
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    for (int k = 0; k < mas.GetLength(2); k++)
                    {

                        if (mas[i, j, k] > 0)
                        {
                            mas[i, j, k] = 0;
                        }
                    }
                }
            }
        }

        public static void Show(double[, ,] mas)
        {
            foreach (var item in mas)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }
    }
}
