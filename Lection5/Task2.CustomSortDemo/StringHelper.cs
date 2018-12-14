using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.CustomSort
{
    public static class StringHelper
    {
        public static string[] Init(this string[] res)
        {
            int n;

            do
            {
                Console.WriteLine("Enter num of strings");
            }
            while (!int.TryParse(Console.ReadLine(), out n));

            res = new string[n];

            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine($"Enter string[{i}].");
                res[i] = Console.ReadLine();
            }

            return res;
        }

        public static void Show(this string[] arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        public static bool Compare(string s1, string s2)
        {
            if(s1.Length > s2.Length)
            {
                return true;
            }
            else if(s1.Length < s2.Length)
            {
                return false;
            }
            else
            {
                if(string.Compare(s1, s2) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
