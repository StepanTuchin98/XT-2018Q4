using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.StudentPractice.Lection3.Task1.Round
{
    public class Round
    {
        #region fields
        private double r;
        public double X { get; set; }
        public double Y { get; set; }
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
                    throw new Exception("Wrong value. Value must be above zero.");
                }
            }
        }

        #endregion fields

        #region ctors
        public Round(double radius, double x, double y)
        {
            this.Radius = radius;
            this.X = x;
            this.Y = y;
        }

        public Round(double radius)
        {
            this.Radius = radius;
            this.X = 0;
            this.Y = 0;
        }


        public Round()
        {
            this.Radius = 1;
            this.X = 0;
            this.Y = 0;
        }
        #endregion ctors

        #region methods
        public double Square() => Math.PI * Radius * Radius;

        public double Length() => 2 * Math.PI * Radius;

        public void Show() => Console.WriteLine($"Radius = {Radius}, X = {X}, Y = {Y}, Square = {Square()}, Lenght = {Length()}");
        public static Round InitRound()
        {
            Round round;
            while (true)
            {
                Console.WriteLine("Enter digit of the x point.");
                if (double.TryParse(Console.ReadLine(), out double x))
                {
                    Console.WriteLine("Enter digit of the y point.");
                    if (double.TryParse(Console.ReadLine(), out double y))
                    {
                        Console.WriteLine("Enter radius.");
                        if (double.TryParse(Console.ReadLine(), out double r))
                        {
                            round = new Round(r, x, y);
                            break;
                        }
                    }
                }
            }
            return round;
        }
        #endregion methods
    }
}
