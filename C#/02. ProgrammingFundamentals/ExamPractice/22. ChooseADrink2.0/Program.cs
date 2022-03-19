using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.ChooseADrink
{
    class Program
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());

            switch (profession)
            {
                case "Athlete":
                    Console.WriteLine("The Athlete has to pay {0:f2}.", (0.70 * quantity));
                    break;
                case "SoftUni Student":
                    Console.WriteLine("The SoftUni Student has to pay {0:f2}.", (1.70 * quantity));
                    break;
                case "Businessman":
                    Console.WriteLine("The Businessman has to pay {0:f2}.", (1.00 * quantity));
                    break;
                case "Businesswoman":
                    Console.WriteLine("The Businesswoman has to pay {0:f2}.", (1.00 * quantity));
                    break;
                default:
                    Console.WriteLine("The {1} has to pay {0:f2}.", (1.20 * quantity), profession);
                    break;
            }
        }
    }
}
