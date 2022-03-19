using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numOne = int.Parse(Console.ReadLine());
            var numTwo = int.Parse(Console.ReadLine());

            //var result = Math.Max(numOne, numTwo) - Math.Min(numOne, numTwo);
            //Console.WriteLine(result);

            for (int i = Math.Min(numOne, numTwo); i <= Math.Max(numTwo, numOne); i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
