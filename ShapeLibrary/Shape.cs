using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeLibrary
{
    public class Shape
    {
        private readonly IFigureArea _figureArea;

        public Shape(IFigureArea figureArea)
        {
            _figureArea = figureArea;
        }

        public double GetArea()
        {
            return _figureArea.GetArea();
        }
    }
}
