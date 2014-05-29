using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestCircles
{
    class TestCircles
    {
        static void Main(string[] args)
        {
            Circle circle1, circle2, circle3;
            circle1 = new Circle();
            circle2 = new Circle();
            circle3 = new Circle();

            circle1.Radius = 5;
            circle2.Radius = 50;

            Console.WriteLine(circle1.Radius);
            Console.WriteLine(circle1.Diameter);
            Console.WriteLine(circle1.Area);

            Console.WriteLine();

            Console.WriteLine(circle2.Radius);
            Console.WriteLine(circle2.Diameter);
            Console.WriteLine(circle2.Area);

            Console.WriteLine();

            Console.WriteLine(circle3.Radius);
            Console.WriteLine(circle3.Diameter);
            Console.WriteLine(circle3.Area);
        }
    }
}
