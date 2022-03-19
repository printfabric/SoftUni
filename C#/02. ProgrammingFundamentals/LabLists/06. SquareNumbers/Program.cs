using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var integers = Console.ReadLine().
            Split(new[] { ' ' }).Select(int.Parse).ToList();
            integers.Sort();
            integers.Reverse();

            for (int i = 0; i < integers.Count; i++)
            {
                var mathSqrt = Math.Sqrt(integers[i]);
                if (mathSqrt % 1 == 0)
                {
                    Console.Write(integers[i] + " ");
                }
            }    
                    
        }
    }
}
