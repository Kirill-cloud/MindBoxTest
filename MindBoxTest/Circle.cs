using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTest
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(int radius)
        {
            Radius = radius;
        }

        public override double CalculateSquare()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
