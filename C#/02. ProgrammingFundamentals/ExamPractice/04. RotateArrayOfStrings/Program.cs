using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.RotateArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrOfStrings = Console.ReadLine()
                .Split(new[] { " " }
                , StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Console.Write(arrOfStrings[arrOfStrings.Length -1]);

            for (int i = 0; i < arrOfStrings.Length - 1; i++)
            {
                Console.Write(" " + arrOfStrings[i]);
            }
        }
    }
}
