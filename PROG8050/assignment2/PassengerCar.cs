using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    class PassengerCar : Vehicle
    {
        public PassengerCar() : base()
        {

        }
        public PassengerCar(int year, string manufacturer, string model, string card) : base(year, manufacturer, model, card)
        {

        }
        public override void SpecificJob()
        {
            Console.WriteLine("Body Tuned up");
        }
        public override string ToString()
        {
            return "Passenger Car";
        }
    }
}
