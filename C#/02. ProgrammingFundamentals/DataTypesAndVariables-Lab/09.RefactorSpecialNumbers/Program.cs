using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumOfDigits = 0;           
            bool special = false;
            for (int i = 1; i <= n; i++)
            {
                var num = i;
                while (num > 0)
                {
                    sumOfDigits += num % 10;
                    num = num / 10;
                }
                
                special = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine($"{i} -> {special}");
                sumOfDigits = 0;
                
            }

        }

    }
    }

