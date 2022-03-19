using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36.VaporStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var balance = double.Parse(Console.ReadLine());
            var currentBalance = balance;
            var game = Console.ReadLine();

            while(game != "Game Time")
            {
                if(currentBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                }

                switch(game)
                {
                    case "OutFall 4":
                        if(currentBalance < 39.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            Console.WriteLine("Bought OutFall 4");
                            currentBalance -= 39.99;
                        }
                        break;
                    case "CS: OG":
                        if (currentBalance < 15.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            Console.WriteLine("Bought CS: OG");
                            currentBalance -= 15.99;
                        }
                        break;
                    case "Zplinter Zell":
                        if (currentBalance < 19.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            Console.WriteLine("Bought Zplinter Zell");
                            currentBalance -= 19.99;
                        }
                        break;
                    case "Honored 2":
                        if (currentBalance < 59.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            Console.WriteLine("Bought Honored 2");
                            currentBalance -= 59.99;
                        }
                        break;
                    case "RoverWatch":
                        if (currentBalance < 29.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            Console.WriteLine("Bought RoverWatch");
                            currentBalance -= 29.99;
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        if (currentBalance < 39.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            Console.WriteLine("Bought RoverWatch Origins Edition");
                            currentBalance -= 39.99;
                        }
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }

                game = Console.ReadLine();
            }
            if(currentBalance <= 0)
            {
                Console.WriteLine("Out of money!");
            }
            else
            {
                Console.WriteLine("Total spent: ${0:f2}. Remaining: ${1:f2}", (balance - currentBalance), currentBalance);
            }
        }
    }
}
