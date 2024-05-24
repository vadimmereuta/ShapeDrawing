using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawing
{
    internal class Cube
    {
        public int width;

        public Cube() 
        { 

        }

        public Cube(int Width)
        {
            width = Width;
        }


        public void Draw()
        {
            for(int i = 0; i < width; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    Console.Write("x ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");
        }

    }
}
