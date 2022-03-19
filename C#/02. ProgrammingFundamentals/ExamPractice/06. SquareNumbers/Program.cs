using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new[] { " " }
                , StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var newList = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if(Math.Sqrt(numbers[i]) == (int)Math.Sqrt(numbers[i]))
                {
                    newList.Add(numbers[i]);
                }
            }

            newList.Sort();
            newList.Reverse();

            Console.WriteLine(string.Join(" ", newList));
        }
    }
}
