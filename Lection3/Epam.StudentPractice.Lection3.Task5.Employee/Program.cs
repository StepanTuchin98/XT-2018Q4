using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = null;
            Console.WriteLine("This app initializes employee.");
            try
            {
                employee = new Employee();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            employee?.Show();


            Employee employee2 = null;
            Console.WriteLine("This app initializes employee.");
            try
            {
                employee2 = new Employee("Senior", 5,"Artemov","Egor","Mihalovich", DateTime.Parse("2005 02 02"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            employee2?.Show();
        }
    }
}
