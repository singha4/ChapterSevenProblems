using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DisplayHousePlants
{
    class DisplayHousePlants
    {
        static void Main(string[] args)
        {
            HousePlant houseplant = new HousePlant();
            houseplant.Name = "Philodendron";
            houseplant.Price = 29.99;
            houseplant.FedLastMonth = true;
            
            Console.WriteLine(houseplant.Name);
            Console.WriteLine(houseplant.Price);
            Console.WriteLine(houseplant.FedLastMonth);

        }
    }
}
