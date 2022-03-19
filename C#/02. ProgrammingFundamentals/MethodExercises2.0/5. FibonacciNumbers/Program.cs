using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int a = 0, b = 1, c = 0;
            
            for (int i = 1; i <= n; i++)
            {
                c = a + b;
                //Console.WriteLine(c);
                a = b;
                b = c;
            }
            Console.WriteLine(c);
        }
    }
}
