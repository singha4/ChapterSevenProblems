using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoSquares
{
    class Square
    {
        private double area;
        private double lengthofaside;

        public Square(int length)
        {
            lengthofaside = length;
            area = length * length;
        }


        public double LengthOfaSide
        {
            get
            {
                return lengthofaside;
            }
        }

        public double Area
        {
            get
            {
                return lengthofaside * lengthofaside;
            }
        }

    }
}
