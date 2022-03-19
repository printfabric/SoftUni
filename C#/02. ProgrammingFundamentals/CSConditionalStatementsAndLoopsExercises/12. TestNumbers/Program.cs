using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var stop = int.Parse(Console.ReadLine());

            var multiply = 0;
            var combinations = 0;

            for (int i = start; i >= 1; i--)
            {

                for (int j = 1; j <= end; j++)
                {

                    combinations++;
                    multiply = multiply + 3 * (i * j);

                    if (multiply >= stop)
                    {
                        i = 0;
                        Console.WriteLine($"{ combinations} combinations");
                        Console.WriteLine($"Sum: {multiply} >= {stop}");
                        break;
                    }

                }

            }

            if (stop > multiply)
            {
                Console.WriteLine($"{ combinations} combinations");
                Console.WriteLine($"Sum: {multiply}");
            }
        }
    }
}
