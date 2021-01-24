using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeLibrary;
using System;

namespace ShapeLibraryTest
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void AreaOfTriangle()
        {
            double expected = 2.9047375096555625;

            var areaOfTriangle = new AreaOfTriangle(2, 3, 4);

            // Assert
            var actual = areaOfTriangle.GetArea();
            Assert.AreEqual(expected, actual, 0.001, "The area of ​​the triangle is calculated incorrectly");
        }

        [TestMethod]
        public void RightTriangle()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            bool expected = true;

            var triangle = new Triangle(a, b, c);

            var actual = triangle.IsRightTriangle();

            Assert.AreEqual(expected, actual);
        }
    }
}
