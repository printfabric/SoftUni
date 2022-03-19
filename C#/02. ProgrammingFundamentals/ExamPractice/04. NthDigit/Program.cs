using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NthDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = long.Parse(Console.ReadLine());
            var index = int.Parse(Console.ReadLine());
            Console.WriteLine(FindNthDigit(number, index));
        }

        static int FindNthDigit(long number, int index)
        {
            for (int i = 0; i < index -1; i++)
            {
                number = number / 10;
            }

            number = number % 10;
            return (int)number;
        }
    }
}
