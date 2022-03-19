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
            var numList = Console.ReadLine().Split('|').ToList();
            numList.Reverse();
            var result = new List<int>();

            for (int i = 0; i < numList.Count; i++)
            {
                var tokens = numList[i].Split(new[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

                foreach (int num in tokens)
                {
                    result.Add(num);
                }
            }

            Console.WriteLine(String.Join(" ", result));
        }
    }
}

