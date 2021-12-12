using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radians_to_degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = double.Parse(Console.ReadLine());
            // var h = double.Parse(Console.ReadLine());


            var F = (180.0 / Math.PI) * d;
            double FRound = Math.Round(F, 2);

            Console.WriteLine("fahrenheit  = " + FRound);

        }
    }
}
