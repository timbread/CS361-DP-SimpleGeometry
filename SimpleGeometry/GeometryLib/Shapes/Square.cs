using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib.Shapes
{
    /// <summary>
    /// Квадрат
    /// </summary>
    public class Square : Shape
    {
        // Длина стороны квадрата
        public double Side { get; }

        public Square(double side)
        {
            Debug.Assert(side > 0, "side > 0");
            Side = side;
        }
        public override double Area()
        {
            return this.Side * this.Side;
        }
        public override string Print()
        {
            return $"Square: side: {this.Side}, area = {this.Area()}";
        }
    }
}
