using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MixedPhones2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameNumber = Console.ReadLine()
                .Split(new[] { ' ', ':' }
                , StringSplitOptions
                .RemoveEmptyEntries)
                .ToList();

            var numbersDictionary = new Dictionary<string, decimal>();

            while(nameNumber[0] != "Over")
            {
                decimal number;
                decimal name;

                if (decimal.TryParse(nameNumber[1], out number))
                {
                    numbersDictionary[nameNumber[0]] = number;
                }
                else if (decimal.TryParse(nameNumber[0], out name))
                {
                    numbersDictionary[nameNumber[1]] = name;
                }

                nameNumber = Console.ReadLine()
                .Split(new[] { ' ', ':' }
                , StringSplitOptions
                .RemoveEmptyEntries)
                .ToList();
            }

            var list = numbersDictionary.Keys.ToList();
            list.Sort();

            foreach (var key in list)
            {
                Console.WriteLine("{0}: {1}", key, numbersDictionary[key]);
            }
        }
    }
}
