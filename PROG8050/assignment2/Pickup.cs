using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    class Pickup : Vehicle
    {
        public Pickup() : base()
        {

        }
        public Pickup(int year, string manufacturer, string model, string card) : base(year, manufacturer, model, card)
        {

        }
        public override void SpecificJob()
        {
            Console.WriteLine("Cover installed");
        }
        public override string ToString()
        {
            return "Pickup Truck";
        }
    }
}
