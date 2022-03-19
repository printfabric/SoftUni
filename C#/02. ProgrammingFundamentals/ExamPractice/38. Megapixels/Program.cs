using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38.Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = decimal.Parse(Console.ReadLine());
            var height = decimal.Parse(Console.ReadLine());
            var MP = Math.Round(((width * height) / 1000000), 1);

            Console.WriteLine($"{width}x{height} => {MP}MP");
        }
    }
}
