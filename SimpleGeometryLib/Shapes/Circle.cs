using SimpleGeometryLib.Abstractions;

namespace SimpleGeometryLib.Shapes
{
    public class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetSquare()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
