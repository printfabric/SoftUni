using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FromTerabytesToBits
{
    class Program
    {
        static void Main(string[] args)
        {
            var terabytes = double.Parse(Console.ReadLine());
            var bits = terabytes * 8796093022208;
            Console.WriteLine(bits);


        }
    }
}
 