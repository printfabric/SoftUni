using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CalculateTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseArea = double.Parse(Console.ReadLine());  
            var height = double.Parse(Console.ReadLine());

            CalculateTriangleAreaWithBaseAndHeight(baseArea, height);
        }

         static void CalculateTriangleAreaWithBaseAndHeight(double baseArea, double height)
        {
            var triangleArea = (baseArea * height) / 2;
            Console.WriteLine(triangleArea);
        }
    }
}
