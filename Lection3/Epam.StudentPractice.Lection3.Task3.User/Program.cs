using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.StudentPractice.Lection3.Task3.User
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = null;
            Console.WriteLine("This app initializes user.");
            try
            {
                user = User.InitUser();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            user?.Show();
        }
    }
}
