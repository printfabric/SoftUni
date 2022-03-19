using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfNumbers = Console.ReadLine()
                .Split(new[] { " " }
                , StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            listOfNumbers.Reverse();

            var count = 0;

            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                if(listOfNumbers[i] > 0)
                {
                    Console.Write(listOfNumbers[i] + " ");
                    count++;
                }
            }
            if(count == 0)
            {
                Console.WriteLine("empty");
            }
        }
    }
}
