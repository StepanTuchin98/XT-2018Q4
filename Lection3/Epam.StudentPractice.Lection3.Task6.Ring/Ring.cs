using Epam.StudentPractice.Lection3.Task1.Round;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.StudentPractice.Lection3.Task6.Ring
{
    public class Ring
    {
        #region fields
        private Round inner;
        private Round outer;

        public Round Inner
        {
            get => inner;
           protected set
            {
                if(value.Radius > Outer?.Radius)
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

        #endregion fields

        #region ctors
        public Ring() : base()
        {

        }
        public Ring(double inR, double outR)
        {
            Inner = new Round(inR);
            Outer = new Round(outR);
        }

        public Ring(double inR, double outR, double x, double y)
        {
            Inner = new Round(inR, x, y);
            Outer = new Round(outR, x, y);
        }

        #endregion ctors

        #region methods
        public double Square() => Outer.Square() - Inner.Square();

        public double Length() => Outer.Length() + Inner.Length();

        public void Show() => Console.WriteLine($"Inner = {Inner.Radius}, X = {Inner.X}, Y = {Inner.Y}, Outer = {Outer.Radius}, X = {Outer.X}, Y = {Outer.Y}, Square = {Square()}, Lenght = {Length()}");

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

        #endregion methods
    }
}
