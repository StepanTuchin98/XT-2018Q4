namespace Task2.CustomSortDemo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Task1.CustomSort;

    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] arr = null;
            arr = StringHelper.Init(arr);
            var func = new Func<string, string, bool>(StringHelper.Compare);
            CustomSort.Sort(ref arr, func);
            Console.WriteLine();
            Console.WriteLine("Sorted array:");
            arr.Show();
        }
    }
}
