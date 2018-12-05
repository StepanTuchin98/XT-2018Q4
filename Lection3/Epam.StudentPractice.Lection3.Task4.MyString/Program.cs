using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.StudentPractice.Lection3.Task4.MyString
{
    class Program
    {
        static void Main(string[] args)
        {
            MyString test1 = new MyString("TesT");
            MyString test2 = test1.SubString(1, 2);
            Console.WriteLine("{0} = {1}: {2} ", test1.ToString(), test2.ToString(), test1 == test2);
            Console.WriteLine(test2?.Str);
            test2 = test1.SubString(1, 5); //Out of indexs
            Console.WriteLine(test2?.Str);
            Console.WriteLine("First T: {0}",test1?.FirstIndexOf('T'));
            Console.WriteLine("Last T: {0}", test1?.LastIndexOf('T'));
            string str = "Letter";
            Console.WriteLine((MyString)str);
            MyString test3 = new MyString("Test3");
            MyString test4 = new MyString("Test4");
            Console.WriteLine($"{test3} + {test4} = {test3 + test4}");
        }
    }
}
