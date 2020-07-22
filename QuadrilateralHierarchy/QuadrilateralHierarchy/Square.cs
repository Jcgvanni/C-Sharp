using System;
using System.Collections.Generic;
using System.Text;
namespace QuadrilateralHierarchy
{
    class Square : Rectangle
    {
        public Square(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4) :
            base(x1, y1, x2, y2, x3, y3, x4, y4)
        {
            side = LengthSizeA();
        }
        public double side;

        public override double getArea()
        {
            return Math.Pow(side, 2);
        }
        public double Sides()
        {
            return side;
        }


        public override string ToString()
        {
            return base.ToString();
        }
    }
}
