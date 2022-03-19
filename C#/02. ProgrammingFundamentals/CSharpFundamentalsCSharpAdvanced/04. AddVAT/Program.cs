using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            var prices = Console.ReadLine()
                .Split(new string[] { "," }
                , StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse);

            Func<double, double> addVAT = p => p * 1.2;

            var lastPrices = prices.Select(addVAT);

            foreach (var price in lastPrices)
            {
                Console.WriteLine($"{price:f2}");
            }
        }
    }
}
