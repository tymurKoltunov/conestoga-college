using System;
using System.Collections.Generic;
using System.Text;

namespace assignment3
{
    class House : Building
    {
        public House(int size = 0, int bulbs = 0, int outlets = 0, string name = "no name given") : base(size, bulbs, outlets, name)
        {
            this.T = BuildingType.House;
            Del += InstallAlarms;
        }
        public void InstallAlarms()
        {
            Console.WriteLine("Fire Alarms installed");
        }
        public override string ToString()
        {
            return "House";
        }
    }
}
