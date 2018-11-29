using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.StudentPractice.Lection1.Task2.CheckSimplicity
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("This app will check, if number is simple.");
            do
            {
                Console.Write("Enter the number to check it! (positive number)");
                int.TryParse(Console.ReadLine(), out n);
            }
            while (n < 1);

            Console.WriteLine("The number is simple: {0}", IsSimple(n));
        }

        public static bool IsSimple(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;
            return true;
        }
    }
}
