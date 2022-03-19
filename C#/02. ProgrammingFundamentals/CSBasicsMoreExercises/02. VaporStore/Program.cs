/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.VaporStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            var balanceDec = currentBalance;
            var breakk = 1;

            while (balanceDec > 0 || game == "Game Time")
            {
                var game = Console.ReadLine();

                switch (game)
                {
                    case "OutFall 4":
                        balanceDec -= 39.99; 
                        break;

                    case "CS: OG":
                        balanceDec -= 15.99;
                        break;

                    case "Zplinter Zell":
                        balanceDec -= 19.99;
                        break;

                    case "Honored 2":
                        balanceDec -= 59.99;
                        break;

                    case "RoverWatch":
                        balanceDec -= 29.99;
                        break;

                    case "RoverWatch Origins Edition":
                        balanceDec -= 39.00;
                        break;
                    case "RoverWatch Origins Edition":
                        balanceDec -= 39.00;
                        break;

                }


            }


        }
    }
}
*/

namespace _02.VaporStore
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var currentBalance = decimal.Parse(Console.ReadLine());
            var totalMoney = currentBalance;

            var buyingOrder = Console.ReadLine();

            while (buyingOrder != "Game Time")
            {

                switch (buyingOrder)
                {
                    case "OutFall 4":
                        if (currentBalance >= 39.99m)
                        {
                            currentBalance -= 39.99m;
                            Console.WriteLine($"Bought OutFall 4");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;

                    case "CS: OG":
                        if (currentBalance >= 15.99m)
                        {
                            currentBalance -= 15.99m;
                            Console.WriteLine($"Bought CS: OG");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;

                    case "Zplinter Zell":
                        if (currentBalance >= 19.99m)
                        {
                            currentBalance -= 19.99m;
                            Console.WriteLine($"Bought Zplinter Zell");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;

                    case "Honored 2":
                        if (currentBalance >= 59.99m)
                        {
                            currentBalance -= 59.99m;
                            Console.WriteLine($"Bought Honored 2");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;

                    case "RoverWatch":
                        if (currentBalance >= 29.99m)
                        {
                            currentBalance -= 29.99m;
                            Console.WriteLine($"Bought RoverWatch");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;

                    case "RoverWatch Origins Edition":
                        if (currentBalance >= 39.99m)
                        {
                            currentBalance -= 39.99m;
                            Console.WriteLine($"Bought RoverWatch Origins Edition");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }

                if (currentBalance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }

                buyingOrder = Console.ReadLine();
            }

            var remainingMoney = totalMoney - currentBalance;
            Console.WriteLine($"Total spent: ${remainingMoney:F2}. Remaining: ${currentBalance:F2}");
        }
    }
}