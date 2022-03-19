using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = long.Parse(Console.ReadLine());
            var end = long.Parse(Console.ReadLine());
            var range = start;

            for (long i = 2; i <= Math.Sqrt(range); i++)
            {
                var prime = (range > 1);

                if (range % i == 0)
                {
                    prime = false;                    
                }

                if (prime && range > start)
                {
                    Console.WriteLine(range);
                }
                //else
                //{
                //    Console.WriteLine(range);
                //}
                range++;
                if (range >= end)
                {
                    break;
                }
            }

        }
    }
}