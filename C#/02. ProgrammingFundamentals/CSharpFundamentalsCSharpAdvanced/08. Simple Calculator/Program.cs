using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Reverse();
            var stack = new Stack<string>(input);
            
            while (stack.Count > 1)
            {
                var leftOperand = int.Parse(stack.Pop());
                var operation = stack.Pop();
                var rightOperand = int.Parse(stack.Pop());

                if(operation == "+")
                {
                    stack.Push((leftOperand + rightOperand).ToString());
                }
                else
                {
                    stack.Push((leftOperand - rightOperand).ToString());
                }
            }

            Console.WriteLine(string.Join(" ", stack));
        }
    }
}
