using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            var groupSize = int.Parse(Console.ReadLine());
            string pakage = Console.ReadLine();
            var price = 0.0;

            if (groupSize <= 50)
            {
                price = 2500;
                Console.WriteLine("We can offer you the Small Hall");
                switch (pakage)
                {
                    case "Normal":
                        price = ((price + 500) * 0.95) / groupSize;
                        Console.WriteLine("The price per person is {0:f2}$", price);
                        break;
                    case "Gold":
                        price = ((price + 750) * 0.90) / groupSize;
                        Console.WriteLine("The price per person is {0:f2}$", price);
                        break;
                    case "Platinum":
                        price = ((price + 1000) * 0.85) / groupSize;
                        Console.WriteLine("The price per person is {0:f2}$", price);
                        break;
                }
                
            }

            else if (groupSize <= 100 && groupSize > 50)
            {
                price = 5000;
                Console.WriteLine("We can offer you the Terrace");
                switch (pakage)
                {
                    case "Normal":
                        price = ((price + 500) * 0.95) / groupSize;
                        Console.WriteLine("The price per person is {0:f2}$", price);
                        break;
                    case "Gold":
                        price = ((price + 750) * 0.90) / groupSize;
                        Console.WriteLine("The price per person is {0:f2}$", price);
                        break;
                    case "Platinum":
                        price = ((price + 1000) * 0.85) / groupSize;
                        Console.WriteLine("The price per person is {0:f2}$", price);
                        break;
                }
            }

            else if (groupSize <= 120 && groupSize > 100)
            {
                price = 7500;
                Console.WriteLine("We can offer you the Great Hall");
                switch (pakage)
                {
                    case "Normal":
                        price = ((price + 500) * 0.95) / groupSize;
                        Console.WriteLine("The price per person is {0:f2}$", price);
                        break;
                    case "Gold":
                        price = ((price + 750) * 0.90) / groupSize;
                        Console.WriteLine("The price per person is {0:f2}$", price);
                        break;
                    case "Platinum":
                        price = ((price + 1000) * 0.85) / groupSize;
                        Console.WriteLine("The price per person is {0:f2}$", price);
                        break;
                }
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }


        }
    }
}
