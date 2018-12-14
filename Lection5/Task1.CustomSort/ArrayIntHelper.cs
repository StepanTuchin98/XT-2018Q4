using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.CustomSort
{
    public static class ArrayIntHelper
    {
        public static void Show(this int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        public static bool Compare(int i1, int i2)
        {
            if (i1 > i2)
            {
                return true;
            }
                return false;
           
        }
    }
}
