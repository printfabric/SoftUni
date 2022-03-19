using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.DistanceOfTheStars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal lightYear = 9450000000000m;
            decimal earthStar = lightYear * 4.22m;
            decimal centerGalaxy = lightYear * 26000m;
            decimal milkyWay = lightYear * 100000m;
            decimal eathToEdge = lightYear * 46500000000m;

            Console.WriteLine((earthStar).ToString("e2"));
            Console.WriteLine((centerGalaxy).ToString("e2"));
            Console.WriteLine((milkyWay).ToString("e2"));
            Console.WriteLine((eathToEdge).ToString("e2"));
        }
    }
}
