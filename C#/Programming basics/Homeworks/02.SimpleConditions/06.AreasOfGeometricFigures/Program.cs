using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasOfGeometricFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = (Console.ReadLine());

            if (figureType == "square")
            {
                var x = double.Parse(Console.ReadLine());
                double area = x * x;
                double areaRound = Math.Round(area, 3);
                Console.WriteLine(areaRound);
                                

            }

            else if (figureType == "rectangle")
            {
                var x = double.Parse(Console.ReadLine());
                var y = double.Parse(Console.ReadLine());
                double area = x * y;
                double areaRound = Math.Round(area, 3);
                Console.WriteLine(areaRound);

             

            }

            else if (figureType == "circle")
            {
                var r = double.Parse(Console.ReadLine());
                double area = (r * r) * Math.PI;
                double areaRound = Math.Round(area, 3);
                Console.WriteLine(areaRound);
                              
            }

            else if (figureType == "triangle")
            {
                var a = double.Parse(Console.ReadLine());
                var h = double.Parse(Console.ReadLine());
                double area = (a * h) / 2.0;
                double areaRound = Math.Round(area, 3);
                Console.WriteLine(areaRound);
            }

           
          
        }
    }
}
