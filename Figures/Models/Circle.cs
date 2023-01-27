namespace Figures.Models
{
    public class Circle : Shape
    {
        public double Radius { get; }
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Круга не существует");

            Radius = radius;
        }
        public double Area => Math.PI * Math.Pow(Radius, 2);

    }
}
