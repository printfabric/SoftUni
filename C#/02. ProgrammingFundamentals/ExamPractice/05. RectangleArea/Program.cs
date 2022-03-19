using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = decimal.Parse(Console.ReadLine());
            var height = decimal.Parse(Console.ReadLine());

            var rectangleArea = width * height;

            Console.WriteLine("{0:f2}", rectangleArea);
        }
    }
}
