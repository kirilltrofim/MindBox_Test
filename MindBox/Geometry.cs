namespace MindBox;

    public class Geometry
    {
        public static double CalculateCircleArea(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Radius cannot be negative");
            }

            return Math.PI * radius * radius;
        }

        public static double CalculateTriangleArea(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw new ArgumentException("Side length cannot be negative");
            }

            if (a + b <= c || b + c <= a || c + a <= b)
            {
                throw new ArgumentException("Invalid triangle");
            }

            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
    }