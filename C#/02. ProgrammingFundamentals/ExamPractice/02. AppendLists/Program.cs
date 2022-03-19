using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split('|').ToList();

            var results = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
               list.Reverse();

                var index = list[i]
                    .Split(new[] { ' ' }
                    , StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                foreach (var num in index)
                {
                    results.Add(num);
                }
            }

            Console.WriteLine(string.Join(" ", results));
        }
    }
}
