namespace Figures.Tests
{
    public class CircleTest
    {
        [Fact]
        public void Circle_Zero_ThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0));
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