using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.ISeekYou
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tmp = { 1, 4, -4, -3, -9, 0, 54, 4 };
            tmp.Show();
            GeneralSort(tmp);
            DelegatSort(tmp);
            AnonSort(tmp);
            LambdaSort(tmp);
            LinqSort(tmp);
        }
        public static void GeneralSort(int[] arr)
        {
            Console.WriteLine("GeneralSort");
            var res = arr.GetPositiveElements();
            res.ForEach(x => Console.Write($"{x} "));
            Console.WriteLine();
        }

        public static void DelegatSort(int[] arr)
        {
            Console.WriteLine("DelegatSort");
            Predicate<int> predicate = GetAboveEight;
            var res = arr.GetPositiveElements(predicate);
            res.ForEach(x => Console.Write($"{x} "));
            Console.WriteLine();
        }

        public static void AnonSort(int[] arr)
        {
            Console.WriteLine("AnonSort");
            Predicate<int> predicate = delegate (int item)
            {
                if (item % 2 == 0)
                {
                    return true;
                }
                else { return false; }
            };

            var res = arr.GetPositiveElements(predicate);
            res.ForEach(x => Console.Write($"{x} "));
            Console.WriteLine();
        }

        public static void LambdaSort(int[] arr)
        {
            Console.WriteLine("LambdaSort");
            Predicate<int> predicate = (x) => (x != 0 ? true : false);
            var res = arr.GetPositiveElements(predicate);
            res.ForEach(x => Console.Write($"{x} "));
            Console.WriteLine();
        }

        public static void LinqSort(int[] arr)
        {
            Console.WriteLine("LinqSort");
            var result = arr.Where(x => x > 4);
            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        public static bool GetAboveEight(int item)
        {
            if (item > 8)
            {
                return true;
            }

            return false;
        }
    }
}
