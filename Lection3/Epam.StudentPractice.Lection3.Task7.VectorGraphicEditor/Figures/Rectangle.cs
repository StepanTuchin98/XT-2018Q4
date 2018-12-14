using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.StudentPractice.Lection3.Task7.VectorGraphicEditor
{
    class Rectangle : Figure
    {
        internal Point RightDownPoint { get; set; }
        internal Point LeftUpPoint { get; set; }

        public Rectangle(Point rightDownPoint, Point leftUpPoint)
        {
            RightDownPoint = rightDownPoint;
            LeftUpPoint = leftUpPoint;
        }

        public Rectangle()
        {
            this.LeftUpPoint = new Point(1,0);
            this.RightDownPoint = new Point(2, 1);
        }

        public Rectangle(double leftX, double leftY, double rightX, double rightY)
        {
            this.LeftUpPoint = new Point(leftX, leftY);
            this.RightDownPoint = new Point(rightX, rightY);
        }
        public override void Show() => Console.WriteLine(
            $"First Point = ({LeftUpPoint.X},{LeftUpPoint.Y}), " +
            $"Second Point = ({RightDownPoint.X},{LeftUpPoint.Y}), " +
            $"Third Point = ({RightDownPoint.X},{RightDownPoint.Y}), " +
            $"Fourth Point = ({LeftUpPoint.X},{RightDownPoint.Y}){Environment.NewLine}");

        public static Rectangle InitRectangle()
        {
            Rectangle rectangle;
            while (true)
            {
                Console.WriteLine("Enter left of the x point.");
                if (double.TryParse(Console.ReadLine(), out double leftX))
                {
                    Console.WriteLine("Enter left of the y point.");
                    if (double.TryParse(Console.ReadLine(), out double leftY))
                    {
                        Console.WriteLine("Enter right of the x point.");
                        if (double.TryParse(Console.ReadLine(), out double rightX))
                        {
                            Console.WriteLine("Enter right of the y point.");
                            if (double.TryParse(Console.ReadLine(), out double rightY))
                            {
                                rectangle = new Rectangle(leftX, leftY, rightX, rightY);
                                break;
                            }
                        }
                    }
                }
            }
            return rectangle;
        }
    }
}
