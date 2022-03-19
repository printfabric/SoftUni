using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ExamShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new Dictionary<string, int>();

            var line = Console.ReadLine();

            while (line != "shopping time")
            {
                var tokens = line.Split();
                var product = tokens[1];
                var quantity = int.Parse(tokens[2]);

                if(!products.ContainsKey(product))
                {
                    products[product] = 0;
                }

                products[product] += quantity;
                line = Console.ReadLine();
            }

            line = Console.ReadLine();
            while (line != "exam time")
            {
                var tokens = line.Split();
                var product = tokens[1];
                var quantity = int.Parse(tokens[2]);

                if (!products.ContainsKey(product))
                {
                    Console.WriteLine($"{product} doesn't exist");
                }
                else 
                {
                    if(products[product] == 0)
                    {
                        Console.WriteLine($"{product} out of stock");
                    }
                    else
                    {
                        products[product] -= quantity;

                        if(products[product] < 0)
                        {
                            products[product] = 0;
                        }
                    }
                }

                line = Console.ReadLine();
            }

            foreach (var productQuantitypair in products)
            {
                var product = productQuantitypair.Key;
                var quantity = productQuantitypair.Value;

                if(quantity > 0)
                {
                    Console.WriteLine($"{product} -> {quantity}");

                }
            }
        }
    }
}
