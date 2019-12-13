using System;

namespace assignment3
{
    public enum BuildingType
    {
        Barn = 1, Garage, House
    }
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Go();
            Console.ReadKey();
        }
        public void Go()
        {
            string next = string.Empty;
            CustomersList customers = new CustomersList();
            int i = 0;
            int type = 0;
            do
            {
                do
                {
                    Console.WriteLine("Choose customers building type:");
                    Console.WriteLine("1. Barn");
                    Console.WriteLine("2. Garage");
                    Console.WriteLine("3. House");                    
                    Console.Write("Enter your type: ");
                } while (!(int.TryParse(Console.ReadLine().Trim(), out type)) || ( type < (int)BuildingType.Barn || (type > (int)BuildingType.House) ) );
                switch (type)
                {
                    default:
                        Console.WriteLine("Someting is wrong");
                        break;
                    case (int)BuildingType.Barn:
                        customers.Add(new Barn());
                        break;
                    case (int)BuildingType.Garage:
                        customers.Add(new Garage());
                        break;
                    case (int)BuildingType.House:
                        customers.Add(new House());
                        break;                    
                }                
                
                int size = 0;
                int bulbs = 0;
                int outlets = 0;
                do
                {
                    Console.Write("Enter customers {0} size[1000 - 50 000]: ",customers[i]);

                } while (!(int.TryParse(Console.ReadLine().Trim(), out size)) || (size < 1000) || (size > 50000));

                customers[i].Size = size;

                do
                {
                    Console.Write("Enter customers desired number of bulbs[1 - 20]: ", customers[i]);

                } while (!(int.TryParse(Console.ReadLine().Trim(), out bulbs)) || (bulbs < 1) || (bulbs > 20));

                customers[i].Bulbs = bulbs;

                do
                {
                    Console.Write("Enter customers number of outlets [1-50]: ", customers[i]);

                } while (!(int.TryParse(Console.ReadLine().Trim(), out outlets)) || (outlets < 1) || (outlets > 50));

                customers[i].Outlets = outlets;

                do
                {
                    Console.Write("Enter customers credit card number(16 digits, no spaces): ");
                    customers[i].CustomerCC = Console.ReadLine().Trim();
                } while (!(CheckCard(customers[i].CustomerCC)));

                do
                {
                    Console.Write("Do you want to add another customer[y/n]?: ");
                    next = Console.ReadLine().Trim();

                } while ((next != "y") && (next != "n"));

                i++;

            } while (next == "y");

            customers.Sort();

            foreach (Building b in customers)
            {
                Console.WriteLine("--------------");
                b.Del();                
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



