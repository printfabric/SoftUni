using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53.VariableInHexadecimalFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(n, 16));
            //Console.WriteLine(Convert.ToInt32("0xFE", 16));

        }
    }
}
