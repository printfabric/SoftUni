using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.GroupNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input =
             {
                1, 4, 113, 55, 3, 1, 2, 66, 557, 124, 2
            };
            int[] sizes = new int[3];

            foreach (var number in input)
            {
                int remainder = number % 3;
                sizes[remainder]++;
            }

            int[][] array =
            {
                new int[sizes[0]], new int[sizes[1]], new int[sizes[2]]
            };

            int[] offsets = new int[3];

            foreach (var number in input)
            {
                int remainder = number % 3;
                int index = offsets[remainder];
                array[remainder][index] = number;
                offsets[remainder]++;
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
