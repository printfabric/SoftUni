using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfInputs = int.Parse(Console.ReadLine());

            var towns = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                var input = Console.ReadLine()
                    .Split(new[] { ' ' }
                    , StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var continent = input[0];
                var country = input[1];
                var city = input[2];

                AddTown(towns, continent, country, city);
            }


            foreach (var continent in towns.Keys)
            {
                Console.WriteLine(continent + ":");
                var townsInContinent = towns[continent];
                foreach (var country in townsInContinent.Keys)
                {
                    Console.WriteLine("  {0} -> {1}", country, string.Join(", ", townsInContinent[country]));
                }

            }

        }
        private static void AddTown(SortedDictionary<string, SortedDictionary<string, SortedSet<string>>> towns,
            string continent, string country, string city)
        {
            if (!towns.ContainsKey(continent))
            {
                towns[continent] = new SortedDictionary<string, SortedSet<string>>();
            }
            if (!towns[continent].ContainsKey(country))
            {
                towns[continent][country] = new SortedSet<string>();
            }

            towns[continent][country].Add(city);
            // towns[continent].Add(grade);
        }
    }
}
