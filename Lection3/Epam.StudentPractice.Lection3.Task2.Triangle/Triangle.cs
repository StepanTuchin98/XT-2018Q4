using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.StudentPractice.Lection3.Task2.Triangle
{
    public class Triangle
    {
        #region fields
        private double a;
        private double b;
        private double c;
        public double A
        {
            get => a;
            set
            {
                if (value > 0)
                {
                    if (B != 0 && C != 0)
                    {
                        if (value < B + C && C < B + value && B < C + value)
                        {
                            this.a = value;
                        }
                        else
                        {
                            throw new Exception("Wrong triangle. A > B + C.");
                        }
                    }
                    else
                    {
                        this.a = value;
                    }
                }
                else
                {
                    throw new Exception("Wrong value. Value must be above zero.");
                }
            }
        }
        public double B
        {
            get => b;
            set
            {
                if (value > 0)
                {
                    if (A != 0 && C != 0)
                    {
                        if (value < A + C && C < A + value && A < C + value)
                        {
                            this.b = value;
                        }
                        else
                        {
                            throw new Exception("Wrong triangle. B > A + C.");
                        }
                    }
                    else
                    {
                        this.b = value;
                    }
                }
                else
                {
                    throw new Exception("Wrong value. Value must be above zero.");
                }
            }
        }
        public double C
        {
            get => c;
            set
            {
                if (value > 0)
                {
                    if (A != 0 && B != 0)
                    {
                        if (value < A + B && B < A + value && A < B + value)
                        {
                            this.c = value;
                        }
                        else
                        {
                            throw new Exception("Wrong triangle. C > A + B.");
                        }
                    }
                    else
                    {
                        this.c = value;
                    }
                }
                else
                {
                    throw new Exception("Wrong value. Value must be above zero.");
                }
            }
        }
        #endregion fields

        #region ctors
        public Triangle(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public Triangle()
        {
            this.A = 1;
            this.B = 1;
            this.C = 1;
        }
        #endregion ctors

        #region methods
        public double Square => Math.Sqrt(HalfPerimeter * (HalfPerimeter - A) * (HalfPerimeter - B) * (HalfPerimeter - C));
 
        public double Perimeter => A + B + C;

        public double HalfPerimeter => Perimeter / 2;

        public void Show() => Console.WriteLine($"A = {A}, B = {B}, C = {C}, Square = {Square}, Perimeter = {Perimeter}");
        public static Triangle InitRound()
        {
            Triangle triangle;
            while (true)
            {
                Console.WriteLine("Enter A side.");
                if (double.TryParse(Console.ReadLine(), out double a))
                {
                    Console.WriteLine("Enter B side.");
                    if (double.TryParse(Console.ReadLine(), out double b))
                    {
                        Console.WriteLine("Enter C side.");
                        if (double.TryParse(Console.ReadLine(), out double c))
                        {
                            triangle = new Triangle(a, b, c);
                            break;
                        }
                    }
                }
            }
            return triangle;
        }

        #endregion methods
    }
}
