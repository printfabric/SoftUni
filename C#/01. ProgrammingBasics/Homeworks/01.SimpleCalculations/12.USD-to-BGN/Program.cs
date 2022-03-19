using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            double bgn =Math.Round(usd * 1.82585039);
            double mathRound = Math.Round(bgn, 2);
            Console.WriteLine(mathRound + " BGN");

        }
    }
}
