using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.StudentPractice.Lection2.Task1.Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This app counts rectangle area.");
            Console.Write("Enter rectangle's sides (positive number)");
            int a, b;

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out a))
                {
                    if (a < 1)
                    {
                        Console.WriteLine("Enter valid numbers.");
                    }
                    else
                    {
                        if (int.TryParse(Console.ReadLine(), out b))
                        {
                            if (b < 1)
                            {
                                Console.WriteLine("Enter valid numbers.");
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }

            Console.WriteLine("Square: {0}", GetArea(a, b));
        }
        public static int GetArea(int a, int b) => a * b;
    }

}
