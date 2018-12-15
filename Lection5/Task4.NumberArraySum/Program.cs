using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.NumberArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 3, 0, 53, -14, 42, 2, -45 };
            int sum = arr.Sum();
            Console.WriteLine($"Summary of array: {sum}");
        }
    }
}
