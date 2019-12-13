using System;
using System.Collections.Generic;
using System.Text;

namespace assignment3
{
    class Garage : Building
    {
        public Garage(int size = 0, int bulbs = 0, int outlets = 0, string name = "no name given") : base(size, bulbs, outlets, name)
        {
            this.T = BuildingType.Garage;
            Del += InstallDoors;
        }
        public void InstallDoors()
        {
            Console.WriteLine("Automatic Doors installed");
        }
        public override string ToString()
        {
            return "Garage";
        }
    }
}
