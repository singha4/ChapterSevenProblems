using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestCircles
{
    class Circle
    {
        private double radius = 1;
        private double diameter;
        private double area;
        
        public double Radius
        {
            get
            {
                return diameter / 2;
            }
            set
            {
                radius = value;
            }
        }

        public double Diameter
        {
            get
            {
                return radius * 2;
            }
            set
            {
                diameter = value;
            }
        }

        public double Area
        {
            get
            {
                return Math.PI * radius * radius;
            }
            set
            {
                area = value;
            }
        }
    }
}
