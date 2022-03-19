using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var digitCount = Math.Ceiling(Math.Log10(num));
            var sumOfOdd = 0;

            Console.WriteLine(GetMultipleOfOdds(num, sumOfOdd) * GetMultipleOfEvens(num, sumOfOdd));
        }

        static int GetMultipleOfOdds(int num, int sumOfOdd)
        {

            while (num != 0)
            {
                if ((num % 2) != 0)
                {
                    sumOfOdd += num % 10;
                }
                num /= 10;
            }
            return sumOfOdd;
        }
        static int GetMultipleOfEvens(int num, int sumOfOdd)
        {

            while (num != 0)
            {
                if ((num % 2) == 0)
                {
                    sumOfOdd += num % 10;
                }
                num /= 10;
            }
            return sumOfOdd;
        }
    }
}
