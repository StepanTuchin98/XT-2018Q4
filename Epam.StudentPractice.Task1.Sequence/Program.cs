using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.StudentPractice.Task1.Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine(GetSequence(N));
        }

        public static String GetSequence(int N)
        {
            List<int> t = new List<int>();
            for (int i = 1; i <= N; i++)
                t.Add(i);

            String rs = String.Join(",", t.ToArray());
            return rs;
        }
    }
}
