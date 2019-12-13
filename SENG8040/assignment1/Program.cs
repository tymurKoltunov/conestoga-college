using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1_part1
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            int value = 0;
            Rectangle r = new Rectangle();
            do
            {
                Console.WriteLine("1. Create default (1 x 1) rectangle");
                Console.WriteLine("2. Create custom rectangle");
                Console.Write("Enter menu option: ");
                if (!int.TryParse(Console.ReadLine(), out input) || (input > 2 || input < 1))
                {
                    Console.WriteLine("Incorrect input");
                    Console.WriteLine();
                }
                else
                    break;
            } while (true);
            switch (input)
            {
                default:
                    Console.WriteLine("Something is wrong");
                    break;
                case 1:
                    input = 0;
                    break;
                case 2:
                    int length = 0;
                    int width = 0;
                    do
                    {
                        Console.Write("Enter length of the rectangle: ");
                        if (!int.TryParse(Console.ReadLine(), out length) || length <= 0)
                        {
                            Console.WriteLine("Incorrect input");
                            Console.WriteLine();
                        }
                        else
                            break;
                    } while (true);
                    do
                    {
                        Console.Write("Enter width of the rectangle: ");
                        if (!int.TryParse(Console.ReadLine(), out width) || width <= 0)
                        {
                            Console.WriteLine("Incorrect input");
                            Console.WriteLine();
                        }
                        else
                            break;
                    } while (true);
                    r = new Rectangle(length, width);
                    input = 0;
                    break;
            }
            Console.WriteLine();
            do
            {
                switch (input)
                {
                    default:
                        Console.WriteLine("Something is wrong");
                        break;
                    case 0:
                        Console.WriteLine("1. Get Rectangle Length");
                        Console.WriteLine("2. Change Rectangle Length");
                        Console.WriteLine("3. Get Rectangle Width");
                        Console.WriteLine("4. Change Rectangle Width");
                        Console.WriteLine("5. Get Rectangle Perimiter");
                        Console.WriteLine("6. Get Rectangle Area");
                        Console.WriteLine("7. Exit");
                        Console.WriteLine();
                        Console.Write("Enter menu option:");
                        if (!int.TryParse(Console.ReadLine(), out input) || (input > 7 || input < 1))
                        {
                            Console.WriteLine("Incorrect input");
                            Console.WriteLine();
                            input = 0;
                        }
                        break;
                    case 1:
                        Console.WriteLine("Length of the rectangle is: {0}", r.GetLength());
                        Console.WriteLine();
                        input = 0;
                        break;
                    case 2:
                        Console.Write("Enter new length:");
                        if (!int.TryParse(Console.ReadLine(), out value) || value <= 0)
                        {
                            Console.WriteLine("Incorrect input");
                            Console.WriteLine();
                            input = 2;
                        }
                        else
                        {
                            Console.WriteLine("Length changed successfully");
                            Console.WriteLine();
                            r.SetLength(value);
                            input = 0;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Width of the rectangle is: {0} ", r.GetWidth());
                        Console.WriteLine();
                        input = 0;
                        break;
                    case 4:
                        Console.Write("Enter new width:");
                        if (!int.TryParse(Console.ReadLine(), out value) || value <= 0)
                        {
                            Console.WriteLine("Incorrect input");
                            Console.WriteLine();
                            input = 4;
                        }
                        else
                        {
                            r.SetWidth(value);
                            Console.WriteLine("Width changed successfully");
                            Console.WriteLine();
                            input = 0;
                        }
                        break;
                    case 5:
                        Console.WriteLine("Perimiter of the rectangle is: {0}", r.GetPerimiter());
                        Console.WriteLine();
                        input = 0;
                        break;
                    case 6:
                        Console.WriteLine("Area of the rectangle is: {0}", r.GetArea());
                        Console.WriteLine();
                        input = 0;
                        break;
                    case 7:
                        return;
                }
            } while (true);        
        }
    }
}
