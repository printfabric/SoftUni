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
            var input = Console.ReadLine()
                .Split(new[] { " ", ":" }
                , StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var phoneBook = new Dictionary<string, long>();

            while(input[0] != "Over")
            {
                long ignoreMe;
                bool successfullyParsed = long.TryParse(input[0], out ignoreMe);
                if (successfullyParsed)
                {
                    phoneBook[input[1]] = long.Parse(input[0]);
                }
                else
                {
                    phoneBook[input[0]] = long.Parse(input[1]);
                }

                input = Console.ReadLine()
                .Split(new[] { " ", ":" }
                , StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            }

            foreach (var number in phoneBook)
            {
                Console.WriteLine(number.Key + " -> " + number.Value);
            }
        }
    }
}
