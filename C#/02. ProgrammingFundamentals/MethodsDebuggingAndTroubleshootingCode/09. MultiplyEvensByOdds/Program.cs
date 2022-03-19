using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Math.Abs(int.Parse(Console.ReadLine()));

            Console.WriteLine(GetMultipleOfEvensAndOdds(n));
           
            


        }

        static int GetMultipleOfEvensAndOdds(int n)
        {
            int sumEvens = GetSumOfTheEvenDigits(n);
            int sumOdds = GetSumOfTheOddDigits(n);
            return sumEvens * sumOdds;
            

        }

        static int GetSumOfTheOddDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 0)
                {
                    sum = lastDigit + sum;
                }

                n /= 10;

            }
            return sum;
        }

        static int GetSumOfTheEvenDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    sum = lastDigit + sum;
                }

                n /= 10;

            }
            return sum;
        }
    }
}
