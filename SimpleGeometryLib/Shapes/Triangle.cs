using SimpleGeometryLib.Abstractions;

namespace SimpleGeometryLib.Shapes
{
    public class Triangle : Shape
    {
        public double SideA { get; }

        public double SideB { get; }

        public double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override double GetSquare()
        {
            var p = (SideA + SideB + SideC) / 2;
            var square = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
            return square;
        }

        public bool IsRectangular()
        {
            var longest = Math.Max(Math.Max(SideA, SideB), SideC);
            var shortest = Math.Min(Math.Min(SideA, SideB), SideC);
            var middle = SideA + SideB + SideC - longest - shortest;

            var isRectangular = longest * longest == shortest * shortest + middle * middle;

            return isRectangular;
        }
    }
}
