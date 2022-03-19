using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EqualSumAfterExtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumbers = Console.ReadLine()
                    .Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

            var secondNumbers = Console.ReadLine()
               .Split(new char[] { ' ' },
               StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();


            //find the equals numbers in both lists
            for (int firs = 0; firs < firstNumbers.Count; firs++)
            {
                var number = firstNumbers[firs];

                for (int second = 0; second < secondNumbers.Count; second++)
                {
                    if (number == secondNumbers[second])
                    {
                        secondNumbers.RemoveAt(second);
                        second--;
                    }
                }
            }

            var firstSum = firstNumbers.Sum();
            var secondSum = secondNumbers.Sum();

            //print result == or !=
            if (firstSum == secondSum)
            {
                Console.WriteLine($"Yes. Sum: {firstSum}");
            }
            else
            {
                var diff = Math.Abs(firstSum - secondSum);
                Console.WriteLine($"No. Diff: {diff}");
            }
        }
    }
}
