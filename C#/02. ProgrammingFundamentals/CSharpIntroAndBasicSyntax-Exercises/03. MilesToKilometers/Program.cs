using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            var miles = decimal.Parse(Console.ReadLine());
            var milesToKm = miles * 1.60934m;
            Console.WriteLine("{0:f2}", milesToKm);

        }
    }
}
