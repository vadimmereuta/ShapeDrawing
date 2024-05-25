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

            Console.WriteLine();
            Circle circle = new Circle(7);
            circle.Draw();

            Console.ReadKey();


        }
    }
}
