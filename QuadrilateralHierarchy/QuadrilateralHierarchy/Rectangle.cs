using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
namespace QuadrilateralHierarchy
{
    class Rectangle : Parallelogram
    {
        public Rectangle(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4):
            base(x1, y1, x2 , y2, x3, y3, x4, y4)
        {
            sideA = LengthSizeA();
            sideC = LengthSizeC();
        }
        public double sideA, sideC;//sideC because it needs the vertical side C

        public override double getArea()
        {
            return sideA * sideC;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }

}
