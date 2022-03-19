using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33.GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var M = int.Parse(Console.ReadLine());
            var magicalNumber = int.Parse(Console.ReadLine());
            var counter = 0;

            for (int i = N; i <= M; i++)
            {
                for (int j = N; j <= M; j++)
                {
                    counter++;
                    if((i + j) == magicalNumber)
                    {
                        Console.WriteLine($"Number found! {j} + {i} = {magicalNumber}");
                        goto End; 
                    }
                }
            }

            Console.WriteLine($"{counter} combinations - neither equals {magicalNumber}");

            End:;
        }
    }
}
