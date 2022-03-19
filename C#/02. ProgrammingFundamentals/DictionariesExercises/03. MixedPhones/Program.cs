using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MixedPhones
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneNumbers = new SortedDictionary<string, decimal>();

            var line = Console.ReadLine();
            while (line != "Over")
            {
                var tokens = line.Split(" :".ToCharArray()
                    , StringSplitOptions
                    .RemoveEmptyEntries);

                var firstElement = tokens[0];
                var secondElement = tokens[1];

                var phoneNumber = 0m;
                if(decimal.TryParse(firstElement, out phoneNumber))
                {
                    phoneNumbers[secondElement] = phoneNumber;
                }
                else if (decimal.TryParse(secondElement, out phoneNumber))
                {
                    phoneNumbers[firstElement] = phoneNumber;
                }

                line = Console.ReadLine();
            }
            foreach (var nameNumber in phoneNumbers)
            {
                var name = nameNumber.Key;
                var phoneNumber = nameNumber.Value;

                Console.WriteLine($"{name} -> {phoneNumber}");
            }

        }
    }
}
