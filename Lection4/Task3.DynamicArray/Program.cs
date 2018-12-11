using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Dynamic_Array;

namespace Task3.DynamicArray
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var dynamicAr = new List<int>();

            for(int i = 0; i < 9; i++)
            {
                dynamicAr.Add(i);
            }

            var res = new DynamicArray<int>(dynamicAr, dynamicAr.Count);
           
            Console.WriteLine($"{Environment.NewLine}Length: {res.Length}{Environment.NewLine}Capacity: {res.Capacity}");

            Console.WriteLine(res.Insert(5, 3));
            Console.WriteLine(res.Remove(0));

            foreach (var item in res)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < res.Length; i++)
            {
                Console.Write($"{res[i]} ");
            }

            Console.WriteLine();
        }
    }
}
