using System;
using System.Collections.Generic;
using System.Text;
namespace QuadrilateralHierarchy
{
    class Trapezoid : Quadrilateral
    {
        public Trapezoid(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4) :
            base(x1, y1, x2, y2, x3, y3, x4, y4)
        {
            sideA = LengthSizeA();
            sideB = LengthSizeB();
            trapHeight = Height();
        }

        public double sideA, sideB, trapHeight;

        //it needs to be virtual to be overrided
        public virtual double getArea()
        {
            return ((sideA + sideB) / 2 * trapHeight);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
