using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.StudentPractice.Lection3.Task6.Ring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This app initializes a ring.");
            Ring ring = null;
            try
            {
                ring = Ring.InitRing();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            ring?.Show();

            
        }
    }
}
