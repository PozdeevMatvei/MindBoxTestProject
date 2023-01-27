namespace Figures.Models
{
    public class Triangle : Shape
    {
        public double[] Sides { get; }
        public Triangle(double a, double b, double c)
        {
            var sides = new double[3] { a, b, c };
            Array.Sort(sides);
            if (sides[0] + sides[1] - sides[2] <= 0)
                throw new ArgumentException("Треугольник не существует");

            Sides = sides;
        }
        public double Area
        {
            get
            {
                return Math.Sqrt(Sides.Sum() / 2 * (Sides.Sum() / 2 - Sides[0])
                                                  * (Sides.Sum() / 2 - Sides[1])
                                                  * (Sides.Sum() / 2 - Sides[2]));
            }
        }
        public bool IsRectangle
        {
            get
            {
                double eps = 1.0E-6;
                Array.Sort(Sides);
                return Math.Abs(Math.Pow(Sides[0], 2) + Math.Pow(Sides[1], 2)
                                                      - Math.Pow(Sides[2], 2)) <= eps;
            }
        }
    }
}
