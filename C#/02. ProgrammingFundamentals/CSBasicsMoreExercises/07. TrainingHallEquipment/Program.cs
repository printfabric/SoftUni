using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.TrainingHallEquipment
{
    class Program
    {
        static void Main(string[] args)
        {

            var budget = double.Parse(Console.ReadLine());
            var numberOfItems = double.Parse(Console.ReadLine());
            var moneySpent = 0.0;
            
            

            for (int i = 0; i < numberOfItems; i++)
            {
                var itemName = Console.ReadLine();
                var itemPrice = double.Parse(Console.ReadLine());
                double itemCount = double.Parse(Console.ReadLine());

                moneySpent += (itemCount * itemPrice);                
                var moneyNeeded = moneySpent - budget;
                

                if ((moneySpent) > budget)
                {
                    Console.WriteLine($"Adding {itemCount} {itemName}s to cart.");
                    Console.WriteLine($"Subtotal: ${moneySpent:f2}");
                    Console.WriteLine($"Not enough. We need ${moneyNeeded:f2} more.");
                }

                else
                {
                    if (itemCount > 1)
                    {
                        Console.WriteLine($"Adding {itemCount} {itemName}s to cart.");
                    }
                    else
                    {
                        Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
                    }
                }
            }
            if (moneySpent < budget)
            {
                var moneyLeft = budget - moneySpent;
                Console.WriteLine($"Subtotal: ${moneySpent:f2}");
                Console.WriteLine("Money left: $" + "{0:f2}", moneyLeft);
            }
        }
    }
}



