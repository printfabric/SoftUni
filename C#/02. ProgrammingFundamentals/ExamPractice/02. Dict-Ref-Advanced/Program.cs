using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Dict_Ref_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToList();


            var dict = new Dictionary<string, List<int>>();

            while (input[0] != "end")
            {
                var name = input[0];
                var value = input[1];
                var values = input[1].Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries).ToList();

                int temp;
                if (int.TryParse(values[0], out temp))
                {
                    dict[name] = new List<int>();
                    for (int i = 0; i < values.Count; i++)
                    {
                        dict[name].Add(int.Parse(values[i]));
                    }
                    //Console.WriteLine("yes");
                }
                else
                {
                    if (dict.ContainsKey(value))
                    {
                        dict[name] = new List<int>();

                        var townsInContinent = dict[value];

                        foreach (var country in townsInContinent)
                        {
                            dict[name].Add(country);
                        }
                    }
                }

                input = Console.ReadLine().Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            foreach (var city in dict.Keys)
            {
                Console.Write(city + " === ");
                Console.Write(string.Join(", ", dict[city]));
                Console.WriteLine();
            }
        }
    }
}
