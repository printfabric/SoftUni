using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Dict_Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ', '=' }
                , StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var dict = new Dictionary<string, string>();

            while (input[0] != "end")
            {
                if (dict.ContainsKey(input[1]))
                {
                    dict[input[0]] = dict[input[1]];
                }
                else
                {
                    dict[input[0]] = input[1];
                }
                //dict[input[0]] = input[1];

                input = Console.ReadLine()
               .Split(new[] { ' ', '=' }
               , StringSplitOptions.RemoveEmptyEntries)
               .ToList();
            }



            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + " === " + item.Value);
            }
        }
    }
}
