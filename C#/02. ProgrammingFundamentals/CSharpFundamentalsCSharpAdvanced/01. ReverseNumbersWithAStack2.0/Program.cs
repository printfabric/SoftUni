using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ReverseNumbersWithAStack2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new[] { ' ' }
                ,StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);
            var stack = new Stack<int>();

            foreach (var item in numbers)
            {
                stack.Push(item);
            }

            Console.WriteLine(string.Join(" ", stack));
        }
    }
}
