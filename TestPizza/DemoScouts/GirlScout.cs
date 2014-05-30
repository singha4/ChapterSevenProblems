using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoScouts
{
    class GirlScout
    {
        private string name;
        private int troopnum;
        private double dues;
        public const string Motto = "to obey the Girl scout law";
        

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int TroopNum
        {
            get
            {
                return troopnum;
            }
            set
            {
                troopnum = value;
            }
        }

        public double Dues
        {
            get
            {
                return dues;
            }
            set
            {
                dues = value;
            }
        }

    }
}
