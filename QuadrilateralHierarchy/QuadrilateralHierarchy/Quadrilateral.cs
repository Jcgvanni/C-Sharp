using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
namespace QuadrilateralHierarchy
{   
    public  class Quadrilateral
    {
        //struct to determine coordinates
        public struct Coordinates
        {
            public double x, y;
            public Coordinates(double point1, double point2)
            {
                x = point1;
                y = point2;

            }
        }
        Coordinates coord1, coord2, coord3, coord4;

        public Quadrilateral(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            //creating (points) coordinates for figures
            coord1 = new Coordinates(x1, y1);
            coord2 = new Coordinates(x2, y2);
            coord3 = new Coordinates(x3, y3);
            coord4 = new Coordinates(x4, y4);
        }

        //methods to get the length of size on each side to calculate areas
        public double LengthSizeA()
        {
            return Math.Abs(coord2.x - coord1.x);
        }
        public double LengthSizeB()
        {
            return Math.Abs(coord4.x - coord3.x);
        }
        public double LengthSizeC()
        {
            return Math.Abs(coord3.y - coord1.y);
        }
        public double LengthSizeD()
        {
            return Math.Abs(coord4.y - coord2.y);
        }

        public double Height()
        {
            return Math.Abs(coord3.y- coord1.y);
        }

        //override tostring to pass struct
        public override string ToString()
        {
            return string.Format("({0:0.0}, {1:0.0}), ({2:0.0}, {3:0.0}), " +
                "({4:0.0}, {5:0.0}), ({6:0.0}, {7:0.0})",
                coord1.x, coord1.y, coord2.x, coord2.y, coord3.x, coord3.y, coord4.x, coord4.y);
        }
    }
}
