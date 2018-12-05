using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.StudentPractice.Lection3.Task7.VectorGraphicEditor
{
    class Line : IFigure
    {
        public Point Begin { set; get; } = new Point();
        public Point End { set; get; } = new Point();

        public Line()
        {
            this.Begin = new Point();
            this.End = new Point(1, 0);
        }
        public Line(Point begin, Point end)
        {
            this.Begin = begin;
            this.End = end;
        }

        public Line(double beginX,  double beginY, double endX, double endY)
        {
            this.Begin = new Point(beginX,beginY);
            this.End = new Point(endX, endY);
        }

        public void Show() => Console.WriteLine($"Begin x = {Begin.X}, Begin y = {Begin.X}, End x = {End.X}, End y = {End.X}{Environment.NewLine}");

        public static Line InitLine()
        {
            Line line;
            while (true)
            {
                Console.WriteLine("Enter begin of the x point.");
                if (double.TryParse(Console.ReadLine(), out double beginX))
                {
                    Console.WriteLine("Enter begin of the y point.");
                    if (double.TryParse(Console.ReadLine(), out double beginY))
                    {
                        Console.WriteLine("Enter end of the x point.");
                        if (double.TryParse(Console.ReadLine(), out double endX))
                        {
                            Console.WriteLine("Enter end of the y point.");
                            if (double.TryParse(Console.ReadLine(), out double endY))
                            {
                                line = new Line(beginX, beginY, endX, endY);
                                break;
                            }
                        }
                    }
                }
            }
            return line;
        }
    }
}
