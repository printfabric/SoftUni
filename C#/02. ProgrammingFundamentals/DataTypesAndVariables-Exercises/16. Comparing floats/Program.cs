using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // int n = int.Parse(Console.ReadLine());
            var a = float.Parse(Console.ReadLine());
            var b = float.Parse(Console.ReadLine());
            var difference = 0.0;
            var eps = 0.000001;

            if (a > b)
            {
                difference = a - b;
            }
            else if (b > a)
            {
                difference = b - a;
            }

            if (difference > eps)
            {
                Console.WriteLine("False");
            }
            else if (difference < eps)
            {
                Console.WriteLine("True");
            }
            else if (difference == eps)
            {
                Console.WriteLine("False");
            }

            //Console.WriteLine("max = " + max);


        }
    }
}
