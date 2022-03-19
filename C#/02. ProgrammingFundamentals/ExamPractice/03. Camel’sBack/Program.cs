using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Camel_sBack
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfInt = Console.ReadLine()
                .Split(new[] { ' ' })
                .Select(int.Parse)
                .ToList();
            var M = int.Parse(Console.ReadLine());
            var N = (listOfInt.Count - M) / 2;

            var newList = new List<int>();

            for (int i = N; i < N + M; i++)
            {
                newList.Add(listOfInt[i]);
            }

            if (N > 0)
            {
                Console.WriteLine($"{N} rounts");
                Console.Write("remaining: " + string.Join(" ", newList));
            }
            else
            {
                Console.WriteLine("already stable: " + string.Join(" ", listOfInt));
            }
        }
    }
}
