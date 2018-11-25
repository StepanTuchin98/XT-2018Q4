using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.StudentPractice.Lection2.Task5.Sum_of_Digits
{
    class Program
    {
        const int Length = 999;
        static void Main(string[] args)
        {
            Console.WriteLine($"This app counts summary of {Length} elements, which is divided by 3 or 5.");
            Console.WriteLine("Summary: {0}", GetSum());

        }
        public static int GetSum()
        {
            int res = 0;
            for (int i = 1; i <= Length; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    res += i;
                }
            }
            return res;
        }
    }
}
