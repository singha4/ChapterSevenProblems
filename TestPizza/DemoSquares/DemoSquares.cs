using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoSquares
{
    class DemoSquares
    {
        static void Main(string[] args)
        {
            Square[] side = new Square[10];

            for (int i = 0; i < side.Length; i++)
            {
                side[i] = new Square(5 + i);
                Console.WriteLine(side[i].Area);
            }

        }
    }
}
