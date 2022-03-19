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
            GetMinFromThreeNumbers();
        }

        private static void GetMinFromThreeNumbers()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            if (a < b)
            {
                if(a < c)
                {
                    Console.WriteLine(a);
                }
                else if (c < a)
                {
                    Console.WriteLine(c);

                }
            }
            else if (b < a)
            {
                if (b < c)
                {
                    Console.WriteLine(b);

                }
                else if (c < b)
                {
                    Console.WriteLine(c);

                }
            }
        }
    }
}
