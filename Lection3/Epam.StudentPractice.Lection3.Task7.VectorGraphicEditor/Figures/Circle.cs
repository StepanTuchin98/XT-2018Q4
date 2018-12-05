using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.StudentPractice.Lection3.Task7.VectorGraphicEditor
{
    class Circle : IFigure
    {
        double r;
        internal Point Center { get; set; }
        public double Radius
        {
            get => r;
            set
            {
                if (value > 0)
                {
                    this.r = value;
                }
                else
                {
                    throw new Exception("Radius must be above 0.");
                }
            }
        }

        public Circle()
        {
            this.Radius = 1;
            this.Center = new Point();
        }

            public Circle(Point center, double radius)
        {
            Center = center;
            Radius = radius;
        }
        public Circle(double radius)
        {
            Center = new Point();
            Radius = radius;
        }

        public virtual void Show() => Console.WriteLine($"Center  = ({Center.X},{Center.Y}){Environment.NewLine}Radius = {Radius}{Environment.NewLine}");

        public static Circle InitCircleOrRound()
        {
            Circle circle;
            while (true)
            {
                Console.WriteLine("Enter digit of the x point.");
                if (double.TryParse(Console.ReadLine(), out double x))
                {
                    Console.WriteLine("Enter digit of the y point.");
                    if (double.TryParse(Console.ReadLine(), out double y))
                    {
                        Console.WriteLine("Enter radius.");
                        if (double.TryParse(Console.ReadLine(), out double R))
                        {
                            circle = new Circle(new Point(x, y), R);
                            break;
                        }
                    }
                }
            }
            return circle;
        }
    }
}
