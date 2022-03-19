using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            var range = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            var command = Console.ReadLine();

            Func<List<int>, string, string> findEvenOrOdd = processEvenOrOdd;

            Console.WriteLine(findEvenOrOdd(range, command));
        }

        private static string processEvenOrOdd(List<int> range, string command)
        {
            var start = range[0];
            var stop = range[1];
            var NumList = new List<int>();

            if (command == "even")
            {
                for (int i = start; i <= stop; i++)
                {
                    if(i % 2 == 0)
                    {
                        NumList.Add(i);
                    }
                }
                var evenList = string.Join(" ", NumList);
                return evenList;
            }

            else
            {
                for (int i = start; i < stop; i++)
                {
                    if (i % 2 != 0)
                    {
                        NumList.Add(i);
                    }
                }
                var List = string.Join(" ", NumList);
                return List;
            }
        }
    }
}
