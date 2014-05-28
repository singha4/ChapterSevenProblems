using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestPizza
{
    class TestPizza
    {
        public static void Main()
        {
            Pizza pizza = new Pizza(16);
            pizza.Toppings = "Peperoni";
            pizza.Diameter = 12;
            pizza.Price = 13.99;

            Console.WriteLine(pizza.Toppings);
            Console.WriteLine(pizza.Diameter);
            Console.WriteLine(pizza.Price);
        }
    }
}
