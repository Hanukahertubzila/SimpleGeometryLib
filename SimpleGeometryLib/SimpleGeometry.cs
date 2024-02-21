namespace SimpleGeometryLib
{
    public static class SimpleGeometry
    {
        public static double GetCircleSquare(double radius)
        {
            return Math.PI * radius * radius;
        }

        public static double GetTriangleSquare(double sideA, double sideB, double sideC)
        {
            var p = (sideA + sideB + sideC) / 2;
            var square = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            return square;
        }

        public static bool IsRectangular(double sideA, double sideB, double sideC)
        {
            var longest = Math.Max(Math.Max(sideA, sideB), sideC);
            var shortest = Math.Min(Math.Min(sideA, sideB), sideC);
            var middle = sideA + sideB + sideC - longest - shortest;

            var isRectangular = longest * longest == shortest * shortest + middle * middle;

            return isRectangular;
        }
    }
}