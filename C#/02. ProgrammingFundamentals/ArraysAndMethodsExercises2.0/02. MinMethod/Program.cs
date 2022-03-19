using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MinMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());                       
            Console.WriteLine(GetMin(a, b, c));
        }

        static int GetMin(int a, int b, int c)
        {
            return Math.Min(a, Math.Min(b, c));
        }
    }
}
