using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawing
{
    internal class Triangle
    {
        public int width;

        public int c1;
        public int c2;
        public int ip;

        public Triangle()
        {

        }

        public Triangle(int Width)
        {
            width = Width;

            c1 = width;
            c2 = width;
            ip = width;
        }
        public Triangle(int a, int b, int c)
        {
            c1 = a;
            c2 = b;
            ip = c;
        }

        //public void DrawIsoscel_1()
        //{
        //    for (int i = 1; i <= width; i++)
        //    {
        //        for (int k = 0; k < width-i; k++)
        //        {
        //            Console.Write("  ");
        //        }

        //        for (int k = 0; k < i; k++)
        //        {
        //            Console.Write("x ");
        //        }

        //        for (int k = 0; k < i; k++)
        //        {
        //            Console.Write("x ");
        //        }

        //        Console.WriteLine();
        //    }

        //}

        public void DrawIsoscel()
        {
            for (int i = 1; i <= width; i++)
            {
                for (int k = 0; k < width - i; k++)
                {
                    Console.Write("  ");
                }

                for (int k = 0; k < i; k++)
                {
                    Console.Write("x ");
                }

                for (int k = 0; k < i-1; k++)
                {
                    Console.Write("x ");
                }

                Console.WriteLine();
            }

        }

        public void DrawRight()
        {
            for (int i = 1; i <= width; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("x ");
                }
                Console.WriteLine();
            }
        }

    }
}
