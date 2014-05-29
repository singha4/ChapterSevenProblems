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
            HousePlant houseplant1, houseplant2, houseplant3;
            houseplant1 = new HousePlant();
            houseplant2 = new HousePlant();
            houseplant3 = new HousePlant();

            houseplant1.Name = "Philodendron";
            houseplant1.Price = 29.99;
            houseplant1.FedLastMonth = true;

            houseplant2.Name = "Daisy";
            houseplant2.Price = 14.99;
            houseplant2.FedLastMonth = false;

            houseplant3.Name = "Tulips";
            houseplant3.Price = 24.99;
            houseplant3.FedLastMonth = true;

            Console.WriteLine(houseplant1.Name);
            Console.WriteLine(houseplant1.Price);
            Console.WriteLine(houseplant1.FedLastMonth);

            Console.WriteLine();

            Console.WriteLine(houseplant2.Name);
            Console.WriteLine(houseplant2.Price);
            Console.WriteLine(houseplant2.FedLastMonth);

            Console.WriteLine();

            Console.WriteLine(houseplant3.Name);
            Console.WriteLine(houseplant3.Price);
            Console.WriteLine(houseplant3.FedLastMonth);

        }
    }
}
