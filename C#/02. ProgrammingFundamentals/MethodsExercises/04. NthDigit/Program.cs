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

            var dogotAtIndex = FindDigi(number, index);

        }

        static int FindDigi(long number, int index)
        {
            var currentIndex = 1;
             while (number > 0)
            {
                if (currentIndex == index)
                {

                }
            }
        }
    }
}
