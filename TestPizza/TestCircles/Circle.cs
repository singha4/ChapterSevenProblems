using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestCircles
{
    class Circle
    {
        private double radius;
        private double diameter;
        private double area;

        public Circle()
        {
            radius = 1;
        }
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
                diameter = radius * 2;
                area = Math.PI * radius * radius;
            }
        }

        public double Diameter
        {
            get
            {
                return diameter;
            }
        }

        public double Area
        {
            get
            {
                return area;
            }
        }
    }
}
