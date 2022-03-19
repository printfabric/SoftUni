using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MultiplyAnArrayOfDoubles
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrOfDoubles = Console.ReadLine()
                .Split(new[] {" "},StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            var p = double.Parse(Console.ReadLine());
            
            for (int i = 0; i < arrOfDoubles.Length; i++)
            {
                arrOfDoubles[i] = arrOfDoubles[i] * p;
            }

            Console.WriteLine(string.Join(" ", arrOfDoubles));



        }
    }
}
