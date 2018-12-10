using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Dynamic_Array;

namespace Task3.DynamicArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var dynamicAr = new List<int>();
            for(int i = 0; i < 20; i++)
            {
                dynamicAr.Add(i);
            }
            var tmp = new DynamicArray<int>(dynamicAr, dynamicAr.Count);
            Console.WriteLine(tmp.Remove(20));
            foreach (var item in tmp)
            {
                Console.WriteLine(item);
            }
        }
    }
}
