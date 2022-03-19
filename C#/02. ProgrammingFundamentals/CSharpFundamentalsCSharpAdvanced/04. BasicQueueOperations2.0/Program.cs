using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BasicQueueOperations2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var newQueue = new Queue<int>();

            var N = input[0];
            var S = input[1];
            var X = input[2];

            var counter = 0;
            for (int i = 0; i < N; i++)
            {
                newQueue.Enqueue(numbers[i]);
            }

            for (int i = 0; i < S; i++)
            {
                newQueue.Dequeue();
            }

            foreach (var item in newQueue)
            {
                if (item == X)
                {
                    Console.WriteLine("true");
                    counter++;
                    break;
                }
            }

            if (newQueue.Count() == 0)
            {
                if (counter == 0)
                    Console.WriteLine("0");
            }

            else
            {
                if (counter == 0)
                    Console.WriteLine(newQueue.Min());
            }
        }
    }
}
