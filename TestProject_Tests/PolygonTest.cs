using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Тестовое_задание;

namespace TestProject_Tests
{
    [TestClass]
    public class PolygonTest
    {
        [TestMethod]
        public void PolygonSimpletest()
        {
            Polygon polygon = new Polygon(new (double, double)[] { (-3, -2), (-1, 4), (6, 1), (3, 10), (-4, 9) });
            Assert.AreEqual(60, polygon.GetArea());
        }
        [TestMethod]
        public void CircleSimpletest()
        {
            Circle circle = new Circle(3);
            Assert.AreEqual(Math.PI * 9, circle.GetArea());
        }
        [TestMethod]
        public void TriangleSimpletest()
        {
            Triangle triangle = new Triangle(2, 2, 2);
            Assert.AreEqual(Math.Sqrt(3), triangle.GetArea());
        }

    }
}
