using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoScouts
{
    class DemoScouts
    {
        static void Main(string[] args)
        {
            GirlScout scout1, scout2, scout3;

            scout1 = new GirlScout();
            scout1.Name = "Heather Sellalot";
            scout1.TroopNum = 17;
            scout1.Dues = 6.35;

            scout2 = new GirlScout();
            scout2.Name = "Lexy";
            scout2.TroopNum = 4;
            scout2.Dues = 6.78;

            scout3 = new GirlScout();
            scout3.Name = "Alpha";
            scout3.TroopNum = 9;
            scout3.Dues = 4.75;

            Console.WriteLine("Name: {0}", scout1.Name);
            Console.WriteLine("Troop Number: {0}", scout1.TroopNum);
            Console.WriteLine("Dues: {0}", scout1.Dues);

            Console.WriteLine();

            Console.WriteLine("Name: {0}", scout2.Name);
            Console.WriteLine("Troop Number: {0}", scout2.TroopNum);
            Console.WriteLine("Dues: {0}", scout2.Dues);

            Console.WriteLine();

            Console.WriteLine("Name: {0}", scout3.Name);
            Console.WriteLine("Troop Number: {0}", scout3.TroopNum);
            Console.WriteLine("Dues: {0}", scout3.Dues);

            Console.WriteLine(GirlScout.Motto); 
        }
    }
}
