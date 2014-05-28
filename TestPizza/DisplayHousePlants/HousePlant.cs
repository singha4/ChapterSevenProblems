using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DisplayHousePlants
{
    class HousePlant
    {
        private string name;
        private double price;
        private bool fedlastmonth;

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

        public bool FedLastMonth
        {
            get
            {
                return fedlastmonth;
            }
            set
            {
                fedlastmonth = value;
            }
        }
    }
}
