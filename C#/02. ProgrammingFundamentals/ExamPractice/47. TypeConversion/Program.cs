using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47.TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var courses = Math.Ceiling((double)n / 24);
            Console.WriteLine(courses);
        }
    }
}
