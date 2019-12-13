using System;
using System.Collections.Generic;
using System.Text;

namespace assignment3
{
    class Barn : Building
    {
        public Barn(int size = 0, int bulbs = 0, int outlets = 0, string name = "no name given") : base(size, bulbs, outlets, name)
        {
            this.T = BuildingType.Barn;
            Del += WireMilking;
        }
        public void WireMilking()
        {
            Console.WriteLine("Milking equipment wired");
        }
        
        public override string ToString()
        {
            return "Barn";
        }
    }
}
