using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var multiplier = int.Parse(Console.ReadLine());

            for (int i = multiplier; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", num, i, (num * i));
            }

            if(multiplier > 10)
            {
                Console.WriteLine("{0} X {1} = {2}", num, multiplier, (num * multiplier));
            }
        }
    }
}
