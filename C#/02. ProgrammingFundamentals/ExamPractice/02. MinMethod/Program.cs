using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MinMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var numOne = int.Parse(Console.ReadLine());
            var numTwo = int.Parse(Console.ReadLine());
            var numThree = int.Parse(Console.ReadLine());

            GerMin(numOne, numTwo, numThree);
        }

        private static void GerMin(int numOne, int numTwo, int numThree)
        {
            Console.WriteLine(Math.Min(numOne, Math.Min(numTwo, numThree)));
        }
    }
}
