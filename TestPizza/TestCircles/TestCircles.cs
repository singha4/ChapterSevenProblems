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

            Console.WriteLine("Radius: {0}", circle1.Radius);
            Console.WriteLine("Diameter: {0}", circle1.Diameter);
            Console.WriteLine("Area: {0}", circle1.Area.ToString("N"));

            Console.WriteLine();

            Console.WriteLine("Radius: {0}", circle2.Radius);
            Console.WriteLine("Diameter: {0}", circle2.Diameter);
            Console.WriteLine("Area: {0}", circle2.Area.ToString("N"));

            Console.WriteLine();

            Console.WriteLine("Radius: {0}", circle3.Radius);
            Console.WriteLine("Diameter: {0}", circle3.Diameter);
            Console.WriteLine("Area: {0}", circle3.Area.ToString("N"));
        }
    }
}
