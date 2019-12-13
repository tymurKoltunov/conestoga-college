using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    class Vehicle
    {
        private int year;
        private string manufacturer;
        private string model;
        private string card;
        public Vehicle()
        {
            this.year = 0;
            this.manufacturer = string.Empty;
            this.model = string.Empty;
            this.card = string.Empty;
        }
        public Vehicle(int year, string manufacturer, string model, string card)
        {
            this.year = year;
            this.manufacturer = manufacturer;
            this.model = model;
            this.card = card;
        }
        public int Year { get => year; set => year = value; }
        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
        public string Model { get => model; set => model = value; }
        public string Card { get => card; set => card = value; }

        public void OilChange()
        {
            Console.WriteLine("Oil Changed");
        }
        public void EngineTuneup()
        {
            Console.WriteLine("Engine tuned up");
        }
        public void TransmissionCleanup()
        {
            Console.WriteLine("Transmision cleaned up");
        }
        public virtual void SpecificJob() { }
        public override string ToString()
        {
            return "Vehicle";
        }
    }
}
