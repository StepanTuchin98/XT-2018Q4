using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Lost
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n;
            while (true)
            {
                Console.WriteLine("Enter n - numbers of people. positive");

                if (int.TryParse(Console.ReadLine(), out n))
                {
                    if (n > 0)
                    {
                        break;
                    }
                }
            }
            
            var people = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                people.Add(i);
            }

            GetLost(ref people);
            Console.WriteLine(people[0]);
        }

        public static void GetLost(ref List<int> people)
        {
            int it = 1;
            while (people.Count > 1)
            {
                it = it % people.Count;
                people.RemoveAt(it);
                it++;
            }
        }
    }
}
