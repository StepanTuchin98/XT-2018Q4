using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.DynamicArrayHardcoremode
{
    class Program
    {
        static void Main(string[] args)
        {
            var vs = new CycledDynamicArray<int>(new List<int> { 1, 2, 3, 4, 5 }, 5);
            foreach (var item in vs)
            {
                Console.WriteLine(item);
            }
        }
    }
}
