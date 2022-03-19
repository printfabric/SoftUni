using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Specialized;
using System.Threading.Tasks;
using System.IO;


namespace _05.LambadaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] {"=>", ".", " "}
                , StringSplitOptions
                .RemoveEmptyEntries)
                .ToList();

            var lambadaExpressions = new Dictionary<string, SortedDictionary<string, string>>();
            //var neeee = new OrderedDictionary(
            var danceCounter = 1;

            while (input[0] != "lambada")
            {
                

                if (input[0] != "dance")
                {
                    var selector = input[0];
                    var selectorObject = input[1];
                    var selectorProperty = input[2];

                    if (!lambadaExpressions.ContainsKey(selector))
                    {
                        lambadaExpressions.Add(selector, new SortedDictionary<string, string>());
                    }

                    lambadaExpressions[selector][selectorObject] = selectorProperty;
                }
                else if(input[0] == "dance")
                {
                    danceCounter++;
                }

                input = Console.ReadLine()
                .Split(new[] { "=>", ".", " " }
                , StringSplitOptions
                .RemoveEmptyEntries)
                .ToList();
            }


            foreach (var lambada in lambadaExpressions)
            {
                //Console.Write(lambada.Key + " => ");
                foreach (var item in lambada.Value)
                {
                    Console.Write(lambada.Key + " => ");

                    for (int i = 0; i < danceCounter; i++)
                    {
                        Console.Write(item.Key + ".");
                    }
                    //Console.Write(item.Key + ".");

                    Console.WriteLine(item.Value);
                }
            }
        }
    }
}
