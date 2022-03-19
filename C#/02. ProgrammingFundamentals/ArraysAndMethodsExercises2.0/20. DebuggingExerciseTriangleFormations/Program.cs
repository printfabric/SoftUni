using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.DebuggingExerciseTriangleFormations
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            var triangleValidityCondition1 = a + b > c;
            var triangleValidityCondition2 = a + c > b;
            var triangleValidityCondition3 = b + c > a;
            var isValidTriangle = triangleValidityCondition1 &&
                triangleValidityCondition2 && triangleValidityCondition3;
            var counter = 0;

            if (!isValidTriangle)
            {
                Console.WriteLine("Invalid Triangle.");
                counter++;             
            }
            else
            {
                Console.WriteLine("Triangle is valid.");
            }

            var rightTriangleCondition1 = a * a + b * b == c * c;
            var rightTriangleCondition2 = b * b + c * c == a * a;
            var rightTriangleCondition3 = a * a + c * c == b * b;

            if (rightTriangleCondition1 && counter == 0)
                Console.WriteLine("Triangle has a right angle between sides a and b");
            else if (rightTriangleCondition2 && counter == 0)
                Console.WriteLine("Triangle has a right angle between sides b and c");
            else if (rightTriangleCondition3 && counter == 0)
                Console.WriteLine("Triangle has a right angle between sides a and c");
            else if(counter == 0)
                Console.WriteLine("Triangle has no right angles.");
        }
    }
}

