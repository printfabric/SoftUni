using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faceRectangleInThePlane
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var a = x1 - x2;
            var b = y2 - y1;

            double positiveB = Math.Abs(b);
            double positiveA = Math.Abs(a);

            var face = positiveA * positiveB;
            var perimeter = 2 * (positiveA + positiveB);

            
            Console.WriteLine("Face = " + face);
            Console.WriteLine("Perimeter = " + perimeter);
        }
    }
}
