using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FlattenDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                var dictionary = new Dictionary<string, Dictionary<string, string>>();

                string inputLine = Console.ReadLine();

                while (inputLine != "end")
                {
                    string[] inputParams = inputLine.Split(' ');

                    if (inputParams[0] != "flatten")
                    {

                        string key = inputParams[0];
                        string innerKey = inputParams[1];
                        string innerValue = inputParams[2];

                        if (!dictionary.ContainsKey(key))
                        {
                            dictionary.Add(key, new Dictionary<string, string>());
                        }
                        else
                        {
                            dictionary[key][innerKey] = innerValue;
                        }

                    } 

                    else
                    {
                        string key = inputParams[1];

                        dictionary[key] = dictionary[key]
                            .ToDictionary(x => x.Key + x.Value, x => "flattened");
                    }
                    inputLine = Console.ReadLine();
                }

                Dictionary<string, Dictionary<string, string>> orderedDictionary =
                    dictionary
                    .OrderByDescending(x => x.Key.Length)
                    .ToDictionary(x => x.Key, x => x.Value);

                foreach (var entry in orderedDictionary)
                {
                    Console.WriteLine("{0}", entry.Key);
                    Dictionary<string, string> orderedInnerDictionary =
                        entry.Value
                        .OrderBy(x => x.Key.Length)
                        .ToDictionary(x => x.Key, x => x.Value);
                    Dictionary<string, string> flattenedValues = entry.Value.Where(x =>)
                }
            }
        }
    }
}
