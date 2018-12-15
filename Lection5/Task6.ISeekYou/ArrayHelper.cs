using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.ISeekYou
{
    public static class ArrayHelper
    {
        public static List<int> GetPositiveElements(this int[] arr)
        {
            var res = new List<int>();
            foreach (var item in arr)
            {
                if(item > 0)
                {
                    res.Add(item);
                }
            }

            return res;
        }

        public static List<int> GetPositiveElements(this int[] arr, Predicate<int> condition)
        {
            var res = new List<int>();
            foreach (var item in arr)
            {
                if (condition(item))
                {
                    res.Add(item);
                }
            }

            return res;
        }

        public static void Show(this int[] arr)
        {
            Console.Write("Array: ");
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

    }
}
