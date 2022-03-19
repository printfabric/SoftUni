using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.LargestNElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new[] { ' ' })
                .Select(int.Parse)
                .ToList();
            var nElements = int.Parse(Console.ReadLine());

            numbers.Sort();
            numbers.Reverse();

            for (int i = 0; i < nElements; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            //Other way without for loop
            //var result = numbers.Take(nElements);
        }
    }
}
