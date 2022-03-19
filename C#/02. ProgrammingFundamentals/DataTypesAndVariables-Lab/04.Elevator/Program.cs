using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var p = int.Parse(Console.ReadLine());
            var courses =  Math.Ceiling(n / p);

            Console.WriteLine(courses);

        }
    }
}
