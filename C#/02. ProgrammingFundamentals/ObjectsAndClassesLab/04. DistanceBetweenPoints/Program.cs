using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DistanceBetweenPoints
{
    class Program
    {
        public static void Main()
        {
            var firstPointParts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var firstPoint = new Point
            {
                x = firstPointParts[0], y = firstPointParts[1]
            };

            var secondPointParts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var secondPoint = new Point
            {
                x = secondPointParts[0], y = secondPointParts[1]
            };

            var result = Distance(firstPoint, secondPoint);
            Console.WriteLine("{0:f3}", result);
        }


        public static double Distance(Point first, Point second)
        {
            var squareX = Math.Pow(first.x - second.x, 2);
            var squareY = Math.Pow(first.y - second.y, 2);
            var result = Math.Sqrt(squareX + squareY);

            return result;
        }
                
    }

    
    
}




