using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.StudentPractice.Lection2.Task12.CharDoubler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This app will double characters in the first string, which existed in the second string.");
            Console.Write("Enter first string:");
            string s1 = Console.ReadLine();
            Console.Write("Enter second string:");
            string s2 = Console.ReadLine();

            Console.WriteLine("Result string:{0}", GetResultStr(new StringBuilder(s1), s2));

        }

        public static string GetResultStr(StringBuilder s1, string s2)
        {
            char[] mas = s2.ToCharArray();
            for(int i = 0; i < s1.Length; i++)
            {
                if (mas.Contains(s1[i]))
                {
                    s1.Insert(i, s1[i]);
                    i++;
                }
            }
            return s1.ToString();
        }
    }
}
