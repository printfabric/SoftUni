using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            var userNum = int.Parse(Console.ReadLine());

            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var aggregateDict = new SortedDictionary<string, SortedSet<string>>();
            var secondDict = new SortedDictionary<string, int>();

            for (int i = 0; i < userNum; i++)
            {   

                var user = input[1];
                var duration = int.Parse(input[2]);
                var IP = input[0];
                var collectDuration = 0;

                input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                //Chek did we already have the user addet
                if (!aggregateDict.ContainsKey(user))
                {
                    aggregateDict[user] = new SortedSet<string>();
                    aggregateDict[user].Add(IP);
                    secondDict[user] = duration;
                }
                else
                {
                    collectDuration = secondDict[user] + duration;
                    aggregateDict[user].Add(IP);
                    secondDict[user] = collectDuration;

                }
            }

            Console.WriteLine();
            foreach (var kvp in aggregateDict)
            {
                Console.Write(kvp.Key + ": " + secondDict[kvp.Key]);
                Console.Write(" [");
                Console.Write(string.Join(", ", kvp.Value));
                Console.Write("]");
                Console.WriteLine();
            }
            
        }
    }
}
