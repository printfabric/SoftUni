using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ChooseADrink
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());
            var totalPrice = 0.0;


            switch (profession)
            {
                case "Athlete":
                    totalPrice = quantity * 0.70;
                    Console.WriteLine("The Athlete has to pay {0:f2}.", totalPrice);
                    break;
                
                case "Businessman":
                    totalPrice = quantity * 1.00;
                    Console.WriteLine("The Businessman has to pay {0:f2}.", totalPrice);
                    break;
                case "Businesswoman":
                    totalPrice = quantity * 1.00;
                    Console.WriteLine("The Businesswoman has to pay {0:f2}.", totalPrice);
                    break;

                case "SoftUni Student":
                    totalPrice = quantity * 1.70;
                    Console.WriteLine("The SoftUni Student has to pay {0:f2}.", totalPrice);
                    break;
                default:
                    totalPrice = quantity * 1.20;
                    Console.WriteLine($"The {profession} has to pay " + "{0:f2}.", totalPrice);                    
                    break;

            }

        }
    }
}
