using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            GetMax(a, b, c);
        }

        static void GetMax(int a, int b, int c)
        {
            
            if (a > b)
            {
                if (b > c)
                {
                    Console.WriteLine(a);
                }
                else if (c > a)
                {
                    Console.WriteLine(c);
                }
            }
            else
            {
                if (a > c)
                {
                    Console.WriteLine(b);
                }
                else if (c > a)
                {
                    Console.WriteLine(c);
                }
            }





        }
    }
}
