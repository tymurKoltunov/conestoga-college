using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    class SchoolBus : Vehicle
    {
        public SchoolBus() : base()
        {

        }
        public SchoolBus(int year, string manufacturer, string model, string card) : base(year, manufacturer, model, card)
        {

        }
        public override void SpecificJob()
        {
            Console.WriteLine("Interior cleaned up");
        }
        public override string ToString()
        {
            return "School Bus";
        }
    }
}
