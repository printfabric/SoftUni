using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.OddNumbersAtOddPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(new[] { ' ' },
           StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0 && i % 2 != 0)
                {
                    Console.WriteLine($"Index {i} -> {array[i]}");
                }
            }
        }
    }
}
