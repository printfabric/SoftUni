using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = (Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            var resoultOme = (((((48 - h) * 3 / 4) + h) + (p * 2 / 3)) * 1.15);
            var resoultTwo = (48 - h) * 3 / 4 + h + (p * 2 / 3);

            switch (year)
            {
                case "leap":
                    Console.WriteLine(Math.Truncate(resoultOme));
                    break;

                case "normal":
                    Console.WriteLine(Math.Truncate(resoultTwo));
                    break;
                


            }
        }
    }
}
