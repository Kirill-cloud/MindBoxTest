using System;
using System.Collections.Generic;
using System.Text;

namespace MindBoxTest
{
    public class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        
        //Проверка на то, является ли треугольник прямоугольным
        public bool IsRightTriangle
        {
            get
            {
                var sides = new List<double>() { SideA, SideB, SideC };
                sides = sides.OrderByDescending(x => x).ToList();
                return sides[0] * sides[0] == sides[1] * sides[1] + sides[2] * sides[2];
            }
        }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override double CalculateSquare()
        {
            //p половина периметра треугольника
            var p = (SideA + SideB + SideC) / 2;
            var sqr = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
            return sqr;
        }
    }
}
