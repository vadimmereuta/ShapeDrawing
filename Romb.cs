using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawing
{
    internal class Romb
    {
        public int width;

        public Romb() 
        {

        }
        public Romb(int width) 
        {
            this.width = width;
        }

        public void Draw()
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

                for (int k = 0; k < i - 1; k++)
                {
                    Console.Write("x ");
                }

                Console.WriteLine();
            }

            for (int i = width - 1; i > 0; i--)
            {
                for (int k = 0; k < width - i; k++)
                {
                    Console.Write("  ");
                }

                for (int k = 0; k < i; k++)
                {
                    Console.Write("x ");
                }

                for (int k = 0; k < i - 1; k++)
                {
                    Console.Write("x ");
                }

                Console.WriteLine();
            }
        }
    }
}
