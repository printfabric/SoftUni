using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CountOfOddNumbersInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrOfInt = Console.ReadLine()
                .Split(new[] { " " }
                , StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var oddElements = 0;

            for (int i = 0; i < arrOfInt.Length; i++)
            {
                if(arrOfInt[i] % 2 != 0)
                {
                    oddElements++;
                }
            }

            Console.WriteLine(oddElements);
        }
    }
}
