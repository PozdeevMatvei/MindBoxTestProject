using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiguresLibrary.Abstract;

namespace FiguresLibrary.Concret
{
    public class Triangle : Figure
    {
        private readonly double a, b, c;
        public Triangle(double a, double b, double c)
        {
            if (!(a+b>c && a+c>b && b+c>a))
                throw new ArgumentException("Такого треугольника не существует.");

            this.a = a;
            this.b = b;
            this.c = c;
        }
        public override Type Type => typeof(Triangle);
        public override double Perimetr => a + b + c;
        public bool IsRectangular => CheckIsRectangular();

        private double SemiP => Perimetr / 2;
        public override double Area => Math.Sqrt(SemiP * (SemiP - a)
                                              * (SemiP - b)
                                              * (SemiP - c));
      
        private bool CheckIsRectangular()
        {
            double a2 = a * a,
                   b2 = b * b,
                   c2 = c * c;

            double calc = a2 + b2 - c2;

            if (calc == 0 || calc == a2 || calc == b2)
                return true;

            return false;
        }
    }
}
