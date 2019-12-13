using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace assignment3
{
    public class House : Building
    {
        public House() : base()
        {

        }
        public House(int size = 0, int bulbs = 0, int outlets = 0, string customerCC = "no card given") : base(size, bulbs, outlets, customerCC)
        {
            this.T = BuildingType.House;
            Del += InstallAlarms;
        }
        public void InstallAlarms()
        {
            //Console.WriteLine("Fire Alarms installed");
            Utilities = "Fire Alarms installed";
        }       
    }
}
