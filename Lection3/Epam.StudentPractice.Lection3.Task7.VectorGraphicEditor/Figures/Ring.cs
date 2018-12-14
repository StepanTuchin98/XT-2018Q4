using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.StudentPractice.Lection3.Task7.VectorGraphicEditor
{
    class Ring : Figure
    {
        private Round inner;
        private Round outer;

        public Round Inner
        {
            get => inner;
            protected set
            {
                if (value.Radius > Outer?.Radius)
                {
                    throw new Exception("Inner radius must be less then outer.");
                }
                else
                {
                    this.inner = value;
                }
            }
        }
        public Round Outer
        {
            get => outer;
            protected set
            {
                if (value.Radius < Inner?.Radius)
                {
                    throw new Exception("Outer radius must be larger then inner.");
                }
                else
                {
                    this.outer = value;
                }
            }
        }
        public Ring()
        {
        }
        public Ring(double inR, double outR)
        {
            Inner = new Round(inR);
            Outer = new Round(outR);
        }

        public Ring(double inR, double outR, double x, double y)
        {
            Inner = new Round(new Point(x,y), inR);
            Outer = new Round(new Point(x, y), outR);
        }

        public double Square() => Outer.Square() - Inner.Square();

        public override void Show() => Console.WriteLine($"Inner = {Inner.Radius}, X = {Inner.Center.X}, Y = {Inner.Center.Y}, Outer = {Outer.Radius}, X = {Outer.Center.X}, Y = {Outer.Center.Y}, Square = {Square()}{Environment.NewLine}");

        public static Ring InitRing()
        {
            Ring ring;
            while (true)
            {
                Console.WriteLine("Enter digit of the x point.");
                if (double.TryParse(Console.ReadLine(), out double x))
                {
                    Console.WriteLine("Enter digit of the y point.");
                    if (double.TryParse(Console.ReadLine(), out double y))
                    {
                        Console.WriteLine("Enter inner radius.");
                        if (double.TryParse(Console.ReadLine(), out double inR))
                        {
                            Console.WriteLine("Enter outer radius.");
                            if (double.TryParse(Console.ReadLine(), out double outR))
                            {
                                ring = new Ring(inR, outR, x, y);
                                break;
                            }
                        }
                    }
                }
            }
            return ring;
        }
    }
}
