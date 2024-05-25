using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawing
{
    internal class Circle
    {
        public int r;

        public Circle()
        {

        }

        public Circle(int radius)
        {
            r = radius;
        }

        public void Draw()
        {
            int d = (r * 2) + 1;

            for(int i  = r; i < d; i++)
            {
                for(int j = 0; j < d/2; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < d; j++)
                {
                    Console.Write("x ");
                }

                Console.WriteLine();
            }
        }




    }
}
