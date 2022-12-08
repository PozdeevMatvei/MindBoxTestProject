using FiguresLibrary.Concret;

namespace FiguresLibrary.Tests
{
    public class TriangleTest
    {
        [Fact]
        public void Triangle_CreateNotValidTriangle_ThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 3));
        }
        [Fact]
        public void Perimetr_CreateTriangle_ValidPerimetr()
        {
            double a = 3, b = 4, c = 5;
            var validPerimetr = a + b + c;
            var triangle = new Triangle(3, 4, 5);

            Assert.Equal(validPerimetr, triangle.Perimetr);
        }
        [Fact]
        public void Area_CreateTriangle_ValidArea()
        {
            double a = 3, b = 4, c = 5;
            double validArea = 6;

            var triangle = new Triangle(a,b,c);

            Assert.Equal(validArea, triangle.Area);
        }
        [Fact]
        public void IsRectangular_CreateRectangularTriangle_True()
        {
            double a = 3, b = 4, c = 5;

            var triangle = new Triangle(a, b, c);

            Assert.True(triangle.IsRectangular);
        }
    }
}
