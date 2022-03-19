using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.CitiesByContinentАndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            var towns = new Dictionary<string, Dictionary<string, string>>();

            AddTown(towns, "Europe", "Bulgaria", "Sofia");
            AddTown(towns, "North America", "USA", "New York");

            foreach (var continent in towns.Key)
            {
                Console.WriteLine("{0}:", continent);
                var townsInContinent = towns[continent];
                foreach (var item in collection)
                {

                }

            }
        }


            private static void AddTown(
                Dictionary<string, Dictionary<string, List<string>>> towns,
                string continent, string country, string town)
        {
            if (!towns.ContainsKey(continent))
            {
                towns[continent] = new Dictionary<string, List<string>>();
            }
            if (!towns[continent].ContainsKey(country))
            {
                towns[continent][country] = new List<string>();
            }
            towns[continent][country].Add(town);
        }

        
    }
}
