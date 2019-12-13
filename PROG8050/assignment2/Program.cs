using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Go();
            Console.ReadKey();
        }
        void Go()
        {
            string next = string.Empty;
            List<Customer> customers = new List<Customer>();
            int i = 0;
            int type = 0;
            do
            {
                customers.Add(new Customer());                
                do
                {
                    Console.Write("Enter customers name: ");
                    customers[i].Name = Console.ReadLine().Trim();
                } while (customers[i].Name.Length == 0);
                
                do
                {
                    Console.WriteLine("Choose customers vehicle type:");
                    Console.WriteLine("1. Passenger Car");
                    Console.WriteLine("2. School Bus");
                    Console.WriteLine("3. Pickup Truck");
                    Console.WriteLine("4. Tractor");
                    Console.Write("Enter your type: ");
                } while (!(int.TryParse(Console.ReadLine().Trim(), out type)) || (type < 1) || (type > 4));
                switch (type)
                {
                    default:
                        Console.WriteLine("Someting is wrong");
                        break;
                    case 1:
                        customers[i].Vehicle = new PassengerCar();
                        break;
                    case 2:
                        customers[i].Vehicle = new SchoolBus();
                        break;
                    case 3:
                        customers[i].Vehicle = new Pickup();
                        break;
                    case 4:
                        customers[i].Vehicle = new Tractor();
                        break;
                }
                
                do
                {
                    Console.Write("Enter manufacturer of the customers vehicle: "); 
                    customers[i].Vehicle.Manufacturer = Console.ReadLine().Trim();
                } while (customers[i].Vehicle.Manufacturer.Length == 0);
                do
                {
                    Console.Write("Enter model of the customers vehicle: ");
                    customers[i].Vehicle.Model = Console.ReadLine().Trim();
                } while (customers[i].Vehicle.Model.Length == 0);

                

                int year = 0;
                do
                {
                    Console.Write("Enter customers vehicle year of issue[1990 - 2010]: ");

                } while (!(int.TryParse(Console.ReadLine().Trim(), out year)) || (year < 1990) || (year > 2010));
                customers[i].Vehicle.Year = year;


                do
                {
                    Console.Write("Enter customers credit card number(16 digits, no spaces): ");
                    customers[i].Vehicle.Card = Console.ReadLine().Trim();
                } while (!(CheckCard(customers[i].Vehicle.Card)));

                do
                {
                    Console.Write("Do you want to add another customer[y/n]?: ");
                    next = Console.ReadLine().Trim();

                } while ((next != "y") && (next != "n"));

                i++;

            } while (next == "y");

            foreach (Customer c in customers)
            {
                Console.WriteLine(c);
                c.Vehicle.OilChange();
                c.Vehicle.EngineTuneup();
                c.Vehicle.TransmissionCleanup();
                c.Vehicle.SpecificJob();
            }

        }

        bool CheckCard(string card)
        {
            if (card.Length != 16)
                return false;
            char[] c = card.ToCharArray();
            for (int j = 0; j < 16; j++)
            {
                if (Char.IsLetter(c[j]) || c[j] == ' ') 
                    return false;
            }
            return true;
        }
    }
}
