using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.MaximumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var newStack = new Stack<int>();
            var max = new Stack<int>();
            max.Push(Int32.MinValue);
            for (int i = 0; i < N; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

                if(input[0] == 1)
                {
                    newStack.Push(input[1]);
                    if(input[1] > max.Peek())
                    {
                        max.Push(input[1]);
                    }
                    
                }
                else if(input[0] == 2)
                {
                    if (max.Peek() == newStack.Peek())
                    {
                        max.Pop();
                    }
                        newStack.Pop();
                    
                }
                else if(input[0] == 3)
                {
                    Console.WriteLine(max.Peek());
                }
            }
        }
    }
}
