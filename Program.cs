using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Shape Drawing";
            Console.ForegroundColor = ConsoleColor.Green;

            Cube cube = new Cube(7);
            cube.Draw();

            Triangle triangle = new Triangle(7);
            triangle.DrawRight();

            Console.WriteLine();
            triangle.DrawIsoscel();

            Console.WriteLine();
            Circle circle = new Circle(7);
            circle.Draw();

            Console.WriteLine();
            Romb romb = new Romb(7);
            romb.Draw();

            Console.ReadKey();


        }
    }
}
