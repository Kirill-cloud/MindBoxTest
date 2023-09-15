using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindBoxTest;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTestTests
{
    [TestClass()]
    public class IHaveSquareTest
    {
        [TestMethod()]
        public void IHaveSquare()
        {

            var circle = new Circle(5);
            var triangle = new Triangle(3, 4, 5);
            var items = new List<IHaveSquare>() { circle, triangle };
            //Вычисление площади фигуры без знания типа фигуры в compile-time
            foreach (var item in items)
            {
                //просто посмотреть что площадь считается в результатах теста
                Debug.WriteLine("Площадь:"+item.CalculateSquare());
            }
        }
    }
}
