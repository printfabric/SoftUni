using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            var groupSize = int.Parse(Console.ReadLine());
            var package = Console.ReadLine();
            var pricePerPerson = 0.0;
            var hall = "";

            if (groupSize <= 50)
            {
                hall = "Small Hall";
                switch (package)
                {
                    case "Normal":
                        pricePerPerson = ((pricePerPerson + 2500 + 500) * 0.95) / groupSize;
                        break;
                    case "Gold":
                        pricePerPerson = ((pricePerPerson + 2500 + 750) * 0.9) / groupSize;
                        break;
                    case "Platinum":
                        pricePerPerson = ((pricePerPerson + 2500 + 1000) * 0.85) / groupSize;
                        break;
                }
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                hall = "Terrace";
                switch (package)
                {
                    case "Normal":
                        pricePerPerson = ((pricePerPerson + 5000 + 500) * 0.95) / groupSize;
                        break;
                    case "Gold":
                        pricePerPerson = ((pricePerPerson + 5000 + 750) * 0.9) / groupSize;
                        break;
                    case "Platinum":
                        pricePerPerson = ((pricePerPerson + 5000 + 1000) * 0.85) / groupSize;
                        break;
                }
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                hall = "Great Hall";
                switch (package)
                {
                    case "Normal":
                        pricePerPerson = ((pricePerPerson + 7500 + 500) * 0.95) / groupSize;
                        break;
                    case "Gold":
                        pricePerPerson = ((pricePerPerson + 7500 + 750) * 0.9) / groupSize;
                        break;
                    case "Platinum":
                        pricePerPerson = ((pricePerPerson + 7500 + 1000) * 0.85) / groupSize;
                        break;
                }
            }

            if (groupSize <= 120)
            {
                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
