using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeLibrary
{
    public class AreaOfCircle : IFigureArea
    {
        private readonly double _radius;

        public AreaOfCircle(double radius)
        {
            _radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
