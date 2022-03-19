using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.AverageStudentshells
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine().Split(new[] { ' ' }).ToList();

            var shells = new Dictionary<string, List<int>>();

            while (input[0] != "Aggregate")
            {
                var city = input[0];
                var shell = int.Parse(input[1]);
            
                AddShell(shells, city, shell);

                input = Console.ReadLine()
                .Split(new[] { ' ' }
                , StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            }
            foreach (var city in shells.Keys)
            {
                Console.Write(city + " -> ");
                Console.Write(string.Join(", ", shells[city]));

                //foreach (var shel in shells[city])
                //{

                //   Console.Write(string.Join(" ", shel + " "));
                //}



                if(shells.Count < 2)
                {
                    var sum = shells[city].Sum();
                    Console.Write($" ({sum})");
                }
                else
                {
                    var sum = (shells[city].Sum()) - ((shells[city].Sum()) / shells[city].Count);
                    Console.Write($" ({sum})");
                }


                Console.WriteLine();

            }

        }
        private static void AddShell(Dictionary<string, List<int>> shells, string city, int shell)
        {
            if (!shells.ContainsKey(city))
            {
                shells[city] = new List<int>();
            }
            shells[city].Add(shell);
        }


    }
}





