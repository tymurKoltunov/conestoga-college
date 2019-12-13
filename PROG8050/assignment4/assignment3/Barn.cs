using System;
using System.Collections.Generic;
using System.Text;

namespace assignment3
{
    public class Barn : Building
    {
        public Barn(int size = 0, int bulbs = 0, int outlets = 0, string customerCC = "no card given") : base(size, bulbs, outlets, customerCC)
        {
            this.T = BuildingType.Barn;
            Del += WireMilking;
        }
        public void WireMilking()
        {
            //Console.WriteLine("Milking equipment wired");
            Utilities = "Milking equipment wired |";
        }
        
        
    }
}
