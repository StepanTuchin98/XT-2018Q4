using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.StudentPractice.Lection3.Task2.Triangle
{
    public class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = null;
            Console.WriteLine("This app initializes a triangle.");
            try
            {
                triangle = Triangle.InitTriangle();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            triangle?.Show();
        }
    }
}
