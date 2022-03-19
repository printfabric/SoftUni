using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DistanceBetweenPoints2._0
{

    class Program
    {
        class  IPoint
        {
            public double X { get; set; }
            public double Y { get; set; }
        }
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var PointParts = Console.ReadLine()
                .Split(new[] { ' ' })
                .Select(int.Parse)
                .ToArray();

                var Point = new IPoint
                {
                    X = PointParts[0],
                    Y = PointParts[1]
                };


            }
            

            //var secondPointParts = Console.ReadLine()
            //    .Split(new[] { ' ' })
            //    .Select(int.Parse)
            //    .ToList();



            

            var secondPoint = new IPoint
            {
                X = secondPointParts[0],
                Y = secondPointParts[1]
            };

            var result = Distance(firstPoint, secondPoint);
            Console.WriteLine("{0:f3}", result);
        }

         static double Distance(IPoint first, IPoint second)
        {
            var squareX = Math.Pow(first.X - second.X, 2);
            var squareY = Math.Pow(first.Y - second.Y, 2);
            var result = Math.Sqrt(squareX + squareY);

            return result;
        }
    }
}
