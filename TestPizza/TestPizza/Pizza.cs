using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestPizza
{
    class Pizza
    {
        private string toppings;

        public Pizza(double Diameter)
        {
            this.Diameter = Diameter;
        }

        public string Toppings
        {
            get
            {
                return toppings;
            }
            set
            {
                toppings = value;
            }
        }

        public double Diameter
        {
            get
            {
                return diameter;
            }
            set
            {
                diameter = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
    }
}
