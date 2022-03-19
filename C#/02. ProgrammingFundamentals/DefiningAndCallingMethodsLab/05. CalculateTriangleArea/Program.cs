using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CalculateTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var triangleWidth = double.Parse(Console.ReadLine());
            var triangleHeight = double.Parse(Console.ReadLine());
            double area = TriangleArea(triangleWidth, triangleHeight);
            Console.WriteLine(area);
        }

        static double TriangleArea(double triangleWidth, double triangleHeight)
        {
            return triangleHeight * triangleWidth / 2;
            
        }
    }
}
