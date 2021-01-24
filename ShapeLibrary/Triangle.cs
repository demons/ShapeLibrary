using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeLibrary
{
    public class Triangle: Shape
    {
        private double[] _sides;

        public Triangle(double a, double b, double c) :
            base(new AreaOfTriangle(a, b, c))
        {
            _sides = new double[] { a, b, c };
            Array.Sort(_sides);
        }

        public bool IsRightTriangle()
        {
            // todo add diffs
            // c^2 = a^2 + b^2
            return Math.Pow(_sides[2], 2) == Math.Pow(_sides[0], 2) + Math.Pow(_sides[1], 2);
        }
    }
}
