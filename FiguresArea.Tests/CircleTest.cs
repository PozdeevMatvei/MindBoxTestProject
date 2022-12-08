using FiguresLibrary.Concret;

namespace FiguresLibrary.Tests
{
    public class CircleTest
    {
        [Fact]
        public void Circle_CreateNotValidCircle_ThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0));
        }
        [Fact]
        public void Perimetr_CreateCircle_ValidPerimetr()
        {
            var radius = 3;
            var validPerimetr = 2 * radius * Math.PI;
            var circle = new Circle(radius);

            Assert.Equal(validPerimetr, circle.Perimetr);

        }
        [Fact]
        public void Area_CreateCircle_ValidArea()
        {
            var radius = 3;
            var validArea = Math.PI * Math.Pow(radius, 2);
            var circle = new Circle(radius);

            Assert.Equal(validArea, circle.Area);
        }
    }
}