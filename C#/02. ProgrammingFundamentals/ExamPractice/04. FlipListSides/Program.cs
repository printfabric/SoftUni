using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FlipListSides
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersList = Console.ReadLine()
                .Split(new[] { " " }
                , StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var newList = new List<int>();
            newList.Add(numbersList[0]);

            numbersList.Reverse();
            for (int i = 1; i < numbersList.Count - 1; i++)
            {
                newList.Add(numbersList[i]);
            }
            newList.Add(numbersList[0]);

            Console.WriteLine(string.Join(" ", newList));
        }
    }
}
