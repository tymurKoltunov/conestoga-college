using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    class Customer
    {
        Vehicle vehicle;
        private string name;
        public Customer()
        {
            this.Vehicle = new Vehicle();
            this.name = string.Empty;
        }
        public Customer(Vehicle vehicle, string name)
        {
            this.Vehicle.Card = vehicle.Card;
            this.Vehicle.Manufacturer = vehicle.Manufacturer;
            this.Vehicle.Model = vehicle.Model;
            this.Vehicle.Year = vehicle.Year;
            this.name = name;

        }
        public string Name { get => name; set => name = value; }
        internal Vehicle Vehicle { get => vehicle; set => vehicle = value; }

        public override string ToString()
        {
            return string.Format("{0} with card number: {5}. Have a {1}. Made by {2}. Model name is {3}. Issued in {4}.", this.name, this.Vehicle, this.Vehicle.Manufacturer, this.Vehicle.Model, this.Vehicle.Year, this.CardOut());
        }
        public string CardOut()
        {
            char[] c = this.Vehicle.Card.ToCharArray();
            for (int i = 4; i < 12; i++)
            {
                c[i] = 'X';
            }
            string r = new string(c);
            return r;
        }
    }
}
