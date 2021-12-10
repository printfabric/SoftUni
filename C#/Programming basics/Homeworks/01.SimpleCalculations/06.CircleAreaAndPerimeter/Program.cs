using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math.r
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());
            var P = double.Parse("3.14159265359");

            var area = P * r * r;
            var perimeter = 2 * P * r;

            Console.WriteLine("Area =" + area);
            Console.WriteLine("Perimeter = " + perimeter);
        }
    }
}
