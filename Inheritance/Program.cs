using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(10, 10);
            Console.WriteLine(point.Name());
            Console.WriteLine(point.Size());

            Line line = new Line(point.X, point.Y, 20, 20);
            Console.WriteLine(line.Name());
            Console.WriteLine(line.Size());

            Square square = new Square(line.X, line.Y, line.X2, line.Y2);
            Console.WriteLine(square.Name());
            Console.WriteLine(square.Size());

            Cube cube = new Cube(square.X, square.Y, square.X2, square.Y2);
            Console.WriteLine(cube.Name());
            Console.WriteLine(cube.Size());

            Figure f1 = point;
            Console.WriteLine(f1.Name());
            Console.WriteLine(f1.Size());

            Figure f2 = square;
            Console.WriteLine(f2.Name());
            Console.WriteLine(f2.Size());

        }
    }
}