using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coddingExersice
{
    class Program
    {
        static void Main(string[] args)
        {
            //var input = Console.ReadLine();

            //var stack = new Stack<char>();

            //for (int i = 0; i < input.Length; i++)
            //{
            //    stack.Push(input[i]);
            //}

            //    Console.WriteLine(string.Join("\r\n", stack));

            //var input = Console.ReadLine();

            //var stack = new Stack<char>();

            //foreach (var @char in input)
            //{
            //    stack.Push(@char);
            //}

            //while (stack.Count > 0)
            //{
            //    Console.Write(stack.Pop());
            //    //Console.Write(" ");
            //}

            var input = int.Parse(Console.ReadLine());

            var stack = new Stack<int>();

            if (input > 0)
            {

                while (input > 0)
                {
                    stack.Push(input % 2);
                    input = Math.Abs(input / 2);
                }
            }
            else
            {
                stack.Push(input);
            }
            Console.WriteLine(string.Join("", stack));
        }
    }
}
