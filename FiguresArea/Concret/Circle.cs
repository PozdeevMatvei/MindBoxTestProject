using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiguresLibrary.Abstract;

namespace FiguresLibrary.Concret
{
    public class Circle : Figure
    {

        public Circle(double radius)
        {
            if (radius > 0)
                Radius = radius;
            else
                throw new ArgumentException("Такого круга не существует.");
        }
        public override Type Type => typeof(Circle);
        public double Radius { get; }
        public override double Perimetr => 2 * Radius * Math.PI;
        public override double Area => Math.PI * Math.Pow(Radius, 2);

       
    }
}
