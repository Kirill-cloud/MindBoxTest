using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindBoxTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTest.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        public void CalculateSquareTest()
        {
            var item = new Circle(5);
            Assert.AreEqual(25*Math.PI,item.CalculateSquare());
        }
    }
}