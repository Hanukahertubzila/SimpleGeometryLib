using SimpleGeometryLib.Shapes;

namespace SimpleGeometryLib.Tests
{
    [TestFixture]
    public class ShapesTests
    {
        [TestCase(3, 4, 5, 6)]
        [TestCase(5, 7, 9, 17.4123)]
        [TestCase(15, 13, 17, 93.8998)]
        public void TriangleGetShapeTest(double sideA, double sideB, double sideC, double expected)
        {
            var triangle = new Triangle(sideA, sideB, sideC);
            Assert.That(triangle.GetSquare(), Is.EqualTo(expected).Within(0.001));
        }

        [TestCase(3, 4, 5, true)]
        [TestCase(5, 7, 9, false)]
        [TestCase(15, 13, 17, false)]
        public void TriangleIsRectangularTest(double sideA, double sideB, double sideC, bool expected)
        {
            var triangle = new Triangle(sideA, sideB, sideC);
            Assert.That(triangle.IsRectangular, Is.EqualTo(expected));
        }

        [TestCase(9, 254.469)]
        [TestCase(7, 153.93804)]
        [TestCase(4, 50.26548)]
        public void CircleGetShapeTest(double radius, double expected)
        {
            var circle = new Circle(radius);
            Assert.That(circle.GetSquare(), Is.EqualTo(expected).Within(0.001));
        }
    }
}