using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var integers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var stack = new Stack<int>();

            var N = integers[0];
            var S = integers[1];
            var X = integers[2];

            var counter = 0;

            var min = Int32.MaxValue;

            for (int i = 0; i < N; i++)
            {
                stack.Push(numbers[i]);
            }

            for (int i = 0; i < S; i++)
            {
                stack.Pop();
            }

            //for (int i = 0; i < stack.Count; i++)
            //{
            //    if (stack.Peek() < min)
            //    {
            //        min = stack.Peek();
            //    }
            //}

            foreach (var item in stack)
            {
                if (item == X)
                {
                    Console.WriteLine("true");
                    counter++;
                    break;
                }
            }
             

            if(stack.Count() > 0 && counter < 1)
            {
                Console.WriteLine(stack.Min());
            }
            if (stack.Count == 0)
            {
                Console.WriteLine("0");
            }
        }
    }
}
