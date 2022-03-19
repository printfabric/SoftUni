using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46.ExactProductOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = decimal.Parse(Console.ReadLine());
            var num = 1m;
            for (int i = 0; i < n; i++)
            {
                var number = decimal.Parse(Console.ReadLine());
                num = num * number;
            }

            Console.WriteLine(num);
        }
    }
}
