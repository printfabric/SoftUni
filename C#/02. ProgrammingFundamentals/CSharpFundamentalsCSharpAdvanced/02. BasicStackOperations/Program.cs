using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ' }
                , StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            var secondInput = Console.ReadLine()
                .Split(new[] { ' ' }
                , StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            var N = input[0];
            var S = input[1];
            var x = input[2];

            var counter = 0;

            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < N; i++)
            {
                numbers.Push(secondInput[i]);
            }

            for (int i = 0; i < S; i++)
            {
                numbers.Pop();
            }

            foreach (var item in numbers)
            {
                if(x == item)
                {
                    Console.WriteLine("true");
                    counter++;
                }
            }

            if(counter == 0)
            {
                Console.WriteLine(numbers.Min());
            }
        }
    }
}


apeks11