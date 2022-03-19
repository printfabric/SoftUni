using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SmallestElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var integers = Console.ReadLine()
                .Split(new[] { " " }
                , StringSplitOptions
                .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(integers.Min());
        }
    }
}
