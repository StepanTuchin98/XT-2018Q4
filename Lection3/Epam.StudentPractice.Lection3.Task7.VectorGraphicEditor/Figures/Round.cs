using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.StudentPractice.Lection3.Task7.VectorGraphicEditor
{
    class Round : Circle
    {
        public Round(Point center, double radius) : base(center, radius)
        {
        }

        public Round(double radius) : base(radius)
        {
        }

        public double Square() => this.Radius * this.Radius * Math.PI;

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Square = {Square()}{Environment.NewLine}");
        }
    }
}
