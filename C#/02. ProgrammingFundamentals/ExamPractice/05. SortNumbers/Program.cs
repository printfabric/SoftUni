using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfNumbers = Console.ReadLine()
                .Split(new[] { ' ' }
                , StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            listOfNumbers.Sort();

            Console.WriteLine(string.Join(" <= ", listOfNumbers));
        }
    }
}
