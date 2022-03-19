using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CirclePerimeter_12_Digits_Precision_
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());
            var radius = (2 * Math.PI) * r;
           Console.WriteLine("{0:f12}", radius);

        }
    }
}
