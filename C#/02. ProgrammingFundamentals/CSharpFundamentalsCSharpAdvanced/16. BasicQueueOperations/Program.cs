using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {

            var integers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var numbers = Console.ReadLine().Split(' ').Reverse().Select(int.Parse).ToArray();
            var queue = new Stack<int>();

            var N = integers[0];
            var S = integers[1];
            var X = integers[2];

            var counter = 0;

            var min = Int32.MaxValue;

            for (int i = 0; i < N; i++)
            {
                queue.Push(numbers[i]);
            }

            for (int i = 0; i < S; i++)
            {
                queue.Pop();
            }

            
            foreach (var item in queue)
            {
                if (item == X)
                {
                    Console.WriteLine("true");
                    counter++;
                    break;
                }
            }


            if (queue.Count() > 0 && counter < 1)
            {
                Console.WriteLine(queue.Min());
            }
            if (queue.Count == 0)
            {
                Console.WriteLine("0");
            }
        }
    }
}
