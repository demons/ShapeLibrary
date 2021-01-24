using System;

namespace ShapeLibrary
{
    public class AreaOfTriangle : IFigureArea
    {
        protected readonly double _a, _b, _c;

        public AreaOfTriangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public double GetArea()
        {
            // Semi-perimeter of the triangle
            var s = (_a + _b + _c) / 2;

            // Area
            return Math.Sqrt(s * (s - _a) * (s - _b) * (s - _c));
        }
    }
}
