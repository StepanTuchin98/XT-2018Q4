using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.StudentPractice.Lection2.Task7.Array_Processing
{
    public class Program
    {
        const int Length = 10;
        static void Main(string[] args)
        {
            int[] mas = GenerateMas();
            Console.WriteLine("Massive");
            Show(mas);
            Console.WriteLine("Min: {0}", GetMin(mas));
            Console.WriteLine("Max: {0}", GetMax(mas));
            Console.WriteLine("Sorted massive");
            Show(GetSortedMas(mas));
        }

        public static int[] GenerateMas()
        {
            int[] tmp = new int[Length];
            Random r = new Random();
            for (int i = 0; i < tmp.Length; i++)
            {
                tmp[i] = r.Next(100);
            }
            return tmp;
        }
        public static void Show(int[] mas)
        {
            foreach (var item in mas)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }
        public static int[] GetSortedMas(int[] mas)
        {
            int temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            return mas;
        }
        public static int GetMin(int[] mas)
        {
            int min = mas[0];
            foreach (var item in mas)
            {
                if(item < min)
                {
                    min = item;
                }
            }
            return min;
        }
        public static int GetMax(int[] mas)
        {
            int max = mas[0];
            foreach (var item in mas)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }
    }
}
