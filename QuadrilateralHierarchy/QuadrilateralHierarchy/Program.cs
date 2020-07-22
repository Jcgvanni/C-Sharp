using System;
namespace QuadrilateralHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrilateral quadrilateral = new Quadrilateral(1.1, 1.2, 6.6, 2.8, 6.2, 9.9, 2.2, 7.4);
            Console.WriteLine("Coordinates of the Quadrillateral are:");
            Console.WriteLine(quadrilateral);
            Console.WriteLine();

            Trapezoid trapezoid = new Trapezoid(0.0, 0.0, 10.0, 0.0, 8.0, 5.0, 3.3, 5.0);
            Console.WriteLine("Coordinates of the Trapezoid are:");
            Console.WriteLine(trapezoid);
            Console.WriteLine("Heigth is: {0}", trapezoid.Height().ToString());
            Console.WriteLine("Area is: {0}", trapezoid.getArea().ToString());
            Console.WriteLine();

            Parallelogram parallelogram = new Parallelogram(5.0, 5.0, 11.0, 5.0, 12.0, 20.0, 6.0, 20.0);
            Console.WriteLine("Coordinates of the Parallelogram are:");
            Console.WriteLine(parallelogram);
            Console.WriteLine("Width is: {0}", parallelogram.Width().ToString());
            Console.WriteLine("Heigth is: {0}", parallelogram.Height().ToString());
            Console.WriteLine("Area is: {0}", parallelogram.getArea().ToString());
            Console.WriteLine();

            Rectangle rectangle = new Rectangle(17.0, 14.0, 30.0, 14.0, 30.0, 28.0, 17.0, 28.0);
            Console.WriteLine("Coordinates of the Rectangle are:");
            Console.WriteLine(rectangle);
            Console.WriteLine("Width is: {0}", rectangle.Width().ToString());
            Console.WriteLine("Heigth is: {0}", rectangle.Height().ToString());
            Console.WriteLine("Area is: {0}", rectangle.getArea().ToString());
            Console.WriteLine();

            Square square = new Square(4.0, 0.0, 8.0, 0.0, 8.0, 4.0, 4.0, 4.0);
            Console.WriteLine("Coordinates of the Square are:");
            Console.WriteLine(square);
            Console.WriteLine("Side is: {0}", square.Sides().ToString());
            Console.WriteLine("Area is: {0}", square.getArea().ToString());
            Console.WriteLine();
        }
    }
}
