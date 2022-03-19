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
            var arrOfNumbers = Console.ReadLine()
                .Split(new[] { " " }
                , StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var oddNumAtOddPos = 0;

            for (int i = 0; i < arrOfNumbers.Length; i++)
            {
                if(i % 2 != 0 && arrOfNumbers[i] % 2 != 0)
                {
                    oddNumAtOddPos++;
                    Console.WriteLine($"Index {i} -> {arrOfNumbers[i]}");
                }
            }
                    
        }
    }
}
