using System;
using System.Collections.Generic;
using System.Text;

namespace assignment3
{
    public class Garage : Building
    {
        public Garage(int size = 0, int bulbs = 0, int outlets = 0, string customerCC = "no card given") : base(size, bulbs, outlets, customerCC)
        {
            this.T = BuildingType.Garage;
            Del += InstallDoors;
        }
        public void InstallDoors()
        {
            //Console.WriteLine("Automatic Doors installed");
            Utilities = "Automatic Doors installed |";
        }
       
    }
}
