using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _02.DictRef
{
    class Program
    {
        static void Main(string[] args)
        {

            var stringsDictionary = new Dictionary<string, int>();
           
                var tokens = Console.ReadLine()
                    .Split(new[] { " ", "=" }, StringSplitOptions
                    .RemoveEmptyEntries)
                    .ToList();

            while (tokens[0] != "end")
            {
                string name = tokens[0]; 
                string value = tokens[1];

                int price;

                if (int.TryParse(value, out price))
                {
                    stringsDictionary[name] = price;
                }
                else
                {
                    if(stringsDictionary.ContainsKey(value))
                    {
                        var referencedValue = stringsDictionary[value];
                        stringsDictionary[name] = referencedValue;
                    }
                    
                }

                tokens = Console.ReadLine()
                    .Split(new[] { " ", "=" }, StringSplitOptions
                    .RemoveEmptyEntries)
                    .ToList();
            }

            foreach (var itemPricePair in stringsDictionary)
            {
                var items = itemPricePair.Key;
                var price = itemPricePair.Value;

                Console.WriteLine($"{items} === {price}");
            }

            Console.WriteLine();             
        }
    }
}

