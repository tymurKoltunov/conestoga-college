using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Go();
            Console.ReadKey();
        }
        enum Trips
        {
            Calgary = 1350,
            Vancouver = 1500,
            Montreal = 575
        }
        public void Go()
        {
            var values = Enum.GetValues(typeof(Trips));
            int totalMoney = 0;
            int totalTrips = 0;
            int quantity = 0;
            bool quantityResult = false;
            Trips city = new Trips();
            foreach(Trips trip in values)
            {
                do
                {
                    Console.Write("How many trips to {0} did Carlo?", trip);
                    if(quantity >= 0)
                        quantityResult = true;                 
                    else
                        quantityResult = false;
                } while (!int.TryParse(Console.ReadLine(), out quantity) || !quantityResult);
                if(quantity == 1)
                {
                    city = trip;
                }
                totalMoney += quantity * (int)trip;
                totalTrips += quantity;
            }
            switch (totalTrips)
            {
                default:
                    Console.WriteLine("Carlo did {0} trips, and spent ${1} on average on each one.", totalTrips, totalMoney / totalTrips);
                    break;
                case 0:
                    Console.WriteLine("Carlo did no trips.");
                    break;
                case 1:
                    Console.WriteLine("Carlo did one trip to {0} and it costed him ${1}.", city, (int)city);
                    break;
            }
        }
    }
}
