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
            var magicalNumber = int.Parse(Console.ReadLine());
            var combinations = 0;
            var count = 0;

            for (int i = start; i <= end; i++)
            {

                for (int j = start; j <= end; j++)
                {

                    combinations++;
                    if ((i + j) == magicalNumber)
                    {
                        count++;
                        Console.WriteLine($"Number found! {j} + {i} = {magicalNumber}");
                        i = end;
                        j = end;
                    }
                }
            }

            if (count == 0)
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicalNumber}");
            }

        }
    }
}
