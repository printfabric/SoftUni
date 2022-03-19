using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var count = 0;
            var sum = 0;
            for (int i = 1; count < n; i += 2)
            {
                Console.WriteLine(i);
                sum += i;
                count++;
            }

            Console.WriteLine("Sum: {0}", sum);
        }
    }
}
