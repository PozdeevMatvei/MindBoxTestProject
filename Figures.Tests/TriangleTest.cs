namespace Figures.Tests
{
    public class TriangleTest
    {
        [Fact]
        public void Triangle_CreateNotValidTriangle_ThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 3));
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

            Assert.True(triangle.IsRectangle);
        }
    }
}
