using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41.TrainingHallEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var numberOfItemsToBuy = int.Parse(Console.ReadLine());
            var Subtotal = 0.0;

            for (int i = 0; i < numberOfItemsToBuy; i++)
            {
                var itemName = Console.ReadLine();
                var itemPrice = double.Parse(Console.ReadLine());
                var itemCount = int.Parse(Console.ReadLine());
                if(itemCount > 1)
                {
                    Console.WriteLine($"Adding {itemCount} {itemName}s to cart.");
                }
                else
                {
                    Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
                }
                Subtotal += (itemPrice * itemCount);

            }

            Console.WriteLine($"Subtotal: ${Subtotal:f2}");
            var money = budget - Subtotal;

            if(money < 1)
            {
                Console.WriteLine("Not enough. We need ${0:f2} more.", Math.Abs(money));
            }
            else
            {
                Console.WriteLine($"Money left: ${money:f2}");
            }
        }
    }
}
