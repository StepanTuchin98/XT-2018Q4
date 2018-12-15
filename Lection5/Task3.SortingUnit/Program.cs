using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Task1.CustomSort;

namespace Task3.SortingUnit
{
    internal class Program
    {
        public static Action<string> isSorted;
        public static void Main(string[] args)
        {
            int[] tmp = { 5, 2, 3, 45, 1, 45, -1, 0, -52, 25, -4 };
            Console.WriteLine("Unsorted array:");
            tmp.Show();
            Action<string> isStopped = x => Console.WriteLine(x.ToString());
            var compare = new Func<int, int, bool>(ArrayIntHelper.Compare);
            var res = StartSortThread(tmp, compare, isStopped, "Event: Array is sorted");
            res.Show();
        }

        public static int[] StartSortThread<T>(int[] arr, Func<T, T, bool> compare, Action<string> isStopped, string letter)
        {
            var func = new Func<int, int, bool>(ArrayIntHelper.Compare);
            isSorted += isStopped;
            Thread newThread = new Thread(() => Sort.SortMas( arr, func));
            newThread.Start();
            newThread.Join(); 
            isSorted.Invoke(letter);
            return arr;  
        }

        

    }
}
