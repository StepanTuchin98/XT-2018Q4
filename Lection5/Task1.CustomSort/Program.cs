using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.CustomSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tmp = { 5, 2, 3, 45, 1, 45, -1, 0, -52, 25, -4 };
            Console.WriteLine("Unsorted array:");
            tmp.Show();
            var func = new Func<int, int, bool>(ArrayIntHelper.Compare);
            CustomSort.Sort(ref tmp, func);
            Console.WriteLine("Sorted array:");
            tmp.Show();


        }
    }
}
