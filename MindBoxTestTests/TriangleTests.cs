using MindBoxTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTest.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void IsRightTriangleTest()
        {
            var item = new Triangle(3, 4, 5);
            Assert.IsTrue(item.IsRightTriangle);
        }

        [TestMethod()]
        public void IsNotRightTriangleTest()
        {
            var item = new Triangle(3, 4, 6);
            Assert.IsFalse(item.IsRightTriangle);
        }

        [TestMethod()]
        public void CalculateSquareTest()
        {
            var item = new Triangle(3, 4, 5);
            Assert.AreEqual(6d, item.CalculateSquare());
        }
    }
}