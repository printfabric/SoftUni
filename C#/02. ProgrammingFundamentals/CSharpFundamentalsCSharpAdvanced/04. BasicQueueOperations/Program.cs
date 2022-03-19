using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var operations = Console.ReadLine()
                .Split(new[] { ' ' }
                , StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            var N = operations[0];
            var S = operations[1];
            var X = operations[2];

            var inputNumbers = Console.ReadLine()
                .Split(new[] { ' ' }
                , StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            var queue = new Queue<int>();
            var counter = 0;

            for (int i = 0; i < N; i++)
            {
                queue.Enqueue(inputNumbers[i]);
            }

            for (int i = 0; i < S; i++)
            {
                queue.Dequeue();
            }

            foreach (var item in queue)
            {
                if(X == item)
                {
                    Console.WriteLine("true");
                    counter++;
                }
            }

            if (queue.Count != 0)
            {
                if (counter == 0)
                {
                    Console.WriteLine(queue.Min());
                }
            }
            else
            {
                Console.WriteLine("0");
            }
            

        }
    }
}
