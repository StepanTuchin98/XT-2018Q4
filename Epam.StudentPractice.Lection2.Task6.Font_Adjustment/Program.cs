using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.StudentPractice.Lection2.Task6.Font_Adjustment
{
    class Program
    {
        public static TypesOfFonts types = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("This app format font style");


            while (true)
            {
                Console.WriteLine("Enter string or float digit to exit");
                Console.WriteLine("Options selected: {0} ", types);
                Console.WriteLine($"Enter{Environment.NewLine}\t\t" +
                    $"1:\t{TypesOfFonts.Bold}{Environment.NewLine}\t\t" +
                    $"2:\t{TypesOfFonts.Italic}{Environment.NewLine}\t\t" +
                    $"3:\t{TypesOfFonts.Underline}{Environment.NewLine}");



                if (int.TryParse(Console.ReadLine(), out int n))
                {
                    switch (n)
                    {
                        case 0:
                            types &= TypesOfFonts.None;
                            break;
                        case 1:
                            if (!types.HasFlag(TypesOfFonts.Bold))
                            {
                                types |= TypesOfFonts.Bold;
                            }
                            else
                            {
                                types ^= TypesOfFonts.Bold;
                            }

                                break;
                        case 2:
                            if (!types.HasFlag(TypesOfFonts.Italic))
                            {
                                types |= TypesOfFonts.Italic;
                            }
                            else
                            {
                                types ^= TypesOfFonts.Italic;
                            }
                            break;
                        case 3:
                            if (!types.HasFlag(TypesOfFonts.Underline))
                            {
                                types |= TypesOfFonts.Underline;
                            }
                            else
                            {
                                types ^= TypesOfFonts.Underline;
                            }
                            break;
                        default:
                            Console.WriteLine("Enter only 1, 2 or 3");
                            break;
                    }

                }
                else
                {
                    break;
                }
            } 
        }
    }
}
