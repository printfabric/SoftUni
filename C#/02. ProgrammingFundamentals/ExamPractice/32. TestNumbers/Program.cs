using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32.TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var M = int.Parse(Console.ReadLine());
            var maxSumBoundary = int.Parse(Console.ReadLine());
            var totalSum = 0;
            var counter = 0;

            for (int i = N; i >= 1; i--)
            {
                for (int j = 1; j <= M; j++)
                {
                    counter++;
                    totalSum = totalSum + ((i * j) * 3);

                    if (totalSum >= maxSumBoundary)
                        goto End;
                }

            }

            End:;

            Console.WriteLine($"{counter} combinations");
            if(totalSum >= maxSumBoundary)
            {
                Console.WriteLine($"Sum: {totalSum} >= {maxSumBoundary}");
            }
            else if(totalSum < maxSumBoundary)
            {
                Console.WriteLine($"Sum: {totalSum}");
            }

        }
    }
}
