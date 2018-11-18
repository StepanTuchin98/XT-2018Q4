using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.StudentPractice.Task2.CheckSimplicity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine(IsSimple(N));
        }
        public static bool IsSimple(int N)
        {
            int cnt = 0;
            for (int i = 2; i <= N / 2; i++)
                if (N % i == 0)
                    cnt++;
            if (cnt == 0)
                return true;
            return false;
        }
    }
}
