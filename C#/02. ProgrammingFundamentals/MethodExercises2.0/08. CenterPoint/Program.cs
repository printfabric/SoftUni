using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            GetClosesPointToCenter(x1, y1, x2, y2);
        }

        static void GetClosesPointToCenter(double x1, double y1,
                                           double x2, double y2)
        {
            var firstPoint = Math.Abs(x1) + Math.Abs(y1);
            var secondPoint = Math.Abs(x2) + Math.Abs(y2);

            if(firstPoint < secondPoint)
            {
                Console.Write("({0}, {1})", x1, y1);
            }
            else if (firstPoint == secondPoint)
            {
                Console.Write("({0}, {1})", x1, y1);

            }
            else
            {
                Console.Write("({0}, {1})", x2, y2);

            }
        }
    }
}
