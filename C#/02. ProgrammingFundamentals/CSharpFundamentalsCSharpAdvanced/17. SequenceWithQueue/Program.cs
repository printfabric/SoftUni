using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.SequenceWithQueue
{
    class Program
    {
        static void Main(string[] args)
        {

            var N = int.Parse(Console.ReadLine());
            var counter = 0;
            var newStack = new Stack<int>();
            newStack.Push(Int32.MaxValue);

            for (int i = 0; i < N; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                if(input[0] >= input[1] && input[0] < newStack.Peek())
                {
                    newStack.Push(input[0]);
                    counter = i;
                }

            }
            Console.WriteLine(counter);
        }
    }
}
