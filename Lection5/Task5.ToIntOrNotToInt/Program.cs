using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.ToIntOrNotToInt
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = Console.ReadLine();
            if (test.IsPositiveInt())
            {
                Console.WriteLine("Positive number.");
            }else
            {
                Console.WriteLine("Not positive number.");
            }
        }
    }
}
