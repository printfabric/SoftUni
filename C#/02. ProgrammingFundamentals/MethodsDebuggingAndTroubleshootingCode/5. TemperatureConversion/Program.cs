using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.TemperatureConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = double.Parse(Console.ReadLine());
            ConvertFahrenheitToCelsius(input);
        }

        private static void ConvertFahrenheitToCelsius(double input)
        {
            var fahrenheitToCelsius = (input - 32) * 5 / 9;
            Console.WriteLine("{0:f2}", fahrenheitToCelsius);
        }
    }
}
