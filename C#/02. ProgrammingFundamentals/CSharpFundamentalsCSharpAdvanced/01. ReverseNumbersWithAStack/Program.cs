using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ReverseNumbersWithAStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();

            var inputNumbers = Console.ReadLine()
                .Split(new[] { ' ' }
                , StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            for (int i = 0; i < inputNumbers.Count; i++)
            {
                numbers.Push(inputNumbers[i]);
            }

            Console.WriteLine(string.Join(" ", numbers));

            //foreach (var item in numbers)
            //{
            //    Console.Write(item);
            //    Console.Write(" ");
            //}
        }
    }
}
