using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.StudentPractice.Lection3.Task7.VectorGraphicEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This app is vector graphics editor");
            string operation;
            int cmd;
            IFigure figure = null;
            do
            {
                Console.WriteLine("You can paint such figures:");
                Console.WriteLine("Type \'end\', if you want to close the app.");
                Console.WriteLine("1. Line");
                Console.WriteLine("2. Circle");
                Console.WriteLine("3. Rectangle");
                Console.WriteLine("4. Ring");
                Console.WriteLine("5. Round");
                operation = Console.ReadLine();
                if (int.TryParse(operation, out cmd))
                {
                    switch (cmd)
                    {
                        case 1:
                            try
                            {
                                figure = Line.InitLine();
                            } catch(Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            figure?.Show();
                            break;
                        case 2:
                            try
                            {
                                figure = Circle.InitCircleOrRound();
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            figure?.Show();
                            break;
                        case 3:
                            try
                            {
                                figure = Rectangle.InitRectangle();
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            figure?.Show();
                            break;
                        case 4:
                            try
                            {
                                figure = Ring.InitRing();
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            figure?.Show();
                            break;
                        case 5:
                            try
                            {
                                figure = Circle.InitCircleOrRound();
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            figure?.Show();
                            break;
                        default:
                            break;
                    }
                }
            } while (!operation.Equals("end"));
        }
    }
}
