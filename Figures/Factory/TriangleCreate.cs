using Figures.Models;

namespace Figures.Factory
{
    public class TriangleCreate : Creator
    {
        public override Triangle FactoryMethod(params double[] values)
        {
            if (values.Length != 3)
                throw new ArgumentException("Треугольник не существует");

            return new Triangle(values[0], values[1], values[2]);
        }
    }
}
