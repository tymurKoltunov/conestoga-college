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
            int menuoption = 0;
            int a = 0, b = 0, c = 0;
            do
            {
                do
                {
                    Console.WriteLine("1. Enter triangle dimensions.");
                    Console.WriteLine("2. Exit.");
                    Console.Write("Enter menu option: ");
                    if (!(int.TryParse(Console.ReadLine().Trim(), out menuoption)) || (menuoption > 2) || (menuoption < 1))
                    {
                        Console.WriteLine("Incorrect input");
                        Console.WriteLine();
                    }
                    else
                        break;
                } while(true);

                switch (menuoption)
                {
                    default:
                        Console.WriteLine("Something is wrong");
                        break;
                    case 1:
                        do
                        {
                            Console.Write("Enter dimension A: ");
                            if (!(int.TryParse(Console.ReadLine().Trim(), out a)) || (a < 1)) //upper limit is defined in integer, as there were no requiremets that would specify the max length of the triangle dimesion
                            {
                                Console.WriteLine("Incorrect Input");
                            }
                            else
                                break;
                        } while (true);
                        do
                        {
                            Console.Write("Enter dimension B: ");
                            if (!(int.TryParse(Console.ReadLine().Trim(), out b)) || (b < 1)) //upper limit is defined in integer, as there were no requiremets that would specify the max length of the triangle dimesion
                            {
                                Console.WriteLine("Incorrect Input");
                            }
                            else
                                break;
                        } while (true);
                        do
                        {
                            Console.Write("Enter dimension C: ");
                            if (!(int.TryParse(Console.ReadLine().Trim(), out c)) || (c < 1)) //upper limit is defined in integer, as there were no requiremets that would specify the max length of the triangle dimesion
                            {
                                Console.WriteLine("Incorrect Input");
                            }
                            else
                                break;
                        } while (true);
                        Console.WriteLine("Your triangle is: {0}", TriangleSolver.Analyze(a, b, c));
                        do
                        {
                            Console.WriteLine("Do you want to enter another triangle?[y/n]");
                            string answer = Console.ReadLine().Trim();
                            if (answer != "y" && answer != "n")
                            {
                                Console.WriteLine("Incorrect Input");
                            }
                            else if (answer == "y")
                                break;
                            else
                                return;
                        } while(true);                        
                        
                        break;
                    case 2:
                        return;                        
                }

            } while (true);
            
        }
    }
}
