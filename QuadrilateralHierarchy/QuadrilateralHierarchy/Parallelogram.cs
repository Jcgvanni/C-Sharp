using System;
using System.Collections.Generic;
using System.Text;
namespace QuadrilateralHierarchy
{
    class Parallelogram : Trapezoid
    {
        public Parallelogram(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4):
            base(x1, y1, x2, y2, x3, y3, x4, y4)
        {
            side = LengthSizeA();
            parallHeight = Height();
        }
        public double side, parallHeight;

        public double Width()
        {
            return side;
        }

        public override double getArea()
        {
            return side * parallHeight;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}

