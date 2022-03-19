using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10.PopulationCounter
{
    static class Program
    {
        static void Main(string[] args)
        {


            var input = Console.ReadLine().Split(' ');

            var CCP = new Dictionary<string, SortedDictionary<int, Dictionary<string, int>>>();

            while (input[0] != "report")
            {

                var country = input[1];
                var city = input[0];
                var population = 0;
                //var totalPopulation = input[1];

                string[] inputCCC = Console.ReadLine()
                    .Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);

                //Chek did we already have the country addet
                if (!CCP.ContainsKey(country))
                {
                    CCP[country] = new SortedDictionary<int, Dictionary<string, int>>();
                    population = population + int.Parse(input[2]);
                    CCP[country][population] = new Dictionary<string, int>();
                }
                //add the country to the continent
                if (!CCP[country][population].ContainsKey(city))
                {
                    CCP[country][population] = new Dictionary<string, int>();
                    CCP[country][population].Add(city, int.Parse(input[1]));
                }

                //add the cities in the country
               // CCP[country][population][city].Add;

               // input = Console.ReadLine()
               // .Split(new[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
            }

        }
    }
}
