using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeLibraryTest
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void AreaOfCircle()
        {
            double expected = 50.26548245743669;

            var areaOfCircle = new AreaOfCircle(4);

            // Assert
            var actual = areaOfCircle.GetArea();
            Assert.AreEqual(expected, actual, 0.001, "The area of ​​the circle is calculated incorrectly");
        }
    }
}
