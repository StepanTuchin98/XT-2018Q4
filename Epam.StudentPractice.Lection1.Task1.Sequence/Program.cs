using System;

namespace Epam.StudentPractice.Task1.Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("This app will show you a sequence.");
            
            do
            {
                Console.Write("Enter the number of the digits (positive number)");
                int.TryParse(Console.ReadLine(), out n);
            }
            while (n < 1);
             
             GetSequence(n);
        }

        public static void GetSequence(int n)
        {
            Console.Write("Your sequance: ");
            for (int i = 1; i < n; i++)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine(n);
            /*
            List<int> t = new List<int>();
            for (int i = 1; i <= n; i++)
                t.Add(i);

            String rs = String.Join(",", t.ToArray());
            return rs;*/
        }
    }
}
