using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Dict_Ref2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine()
                .Split(new[] { ' ', '=' }
                , StringSplitOptions
                .RemoveEmptyEntries).ToList();

            var items = new Dictionary<string, int>();


            while(inputLine[0] !="end")
            {
                int value;

                if(int.TryParse(inputLine[1], out value))
                {
                    items[inputLine[0]] = value;
                }
                else
                {
                    if (items.ContainsKey(inputLine[1]))
                    {
                        var referencedValue = items[inputLine[1]];
                        items[inputLine[0]] = referencedValue;
                    }
                }
                inputLine = Console.ReadLine()
               .Split(new[] { ' ', '=' }
               , StringSplitOptions
               .RemoveEmptyEntries).ToList();

            }

            foreach (var kvp in items)
            {
                Console.WriteLine(kvp.Key + " === " + kvp.Value);
            }

            

        }
    }
}
