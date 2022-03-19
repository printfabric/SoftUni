using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SequenceWithQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var queue = new Queue<int>();
            var result = new List<int>();
            queue.Enqueue(n);
            result.Add(n);

            for (int i = 0; i < 50; i++)
            {
                var currentNumber = queue.Dequeue();

                var firstNumber = currentNumber + 1;
                var secondNumber = (currentNumber * 2) + 1;
                var thirdNumber = currentNumber + 2;

                queue.Enqueue(firstNumber);
                queue.Enqueue(secondNumber);
                queue.Enqueue(thirdNumber);

                result.Add(firstNumber);
                result.Add(secondNumber);
                result.Add(thirdNumber);
                                
            }

            for (int i = 0; i < 50; i++)
            {
                Console.Write(result[i] + " ");
            }
        }
    }
}
