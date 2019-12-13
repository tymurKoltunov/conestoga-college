using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    class Tractor : Vehicle
    {
        public Tractor() : base()
        {

        }
        public Tractor(int year, string manufacturer, string model, string card) : base(year, manufacturer, model, card)
        {

        }
        public override void SpecificJob()
        {
            Console.WriteLine("PTO maintenance completed");
        }
        public override string ToString()
        {
            return "Tractor";
        }
    }
}
