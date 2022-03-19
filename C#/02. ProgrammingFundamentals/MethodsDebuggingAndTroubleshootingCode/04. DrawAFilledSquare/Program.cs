using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DrawAFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            PrintLineHeaderFooter(n);
            PrintMiddlePart(n);
            PrintLineHeaderFooter(n);            
        }

        static void PrintMiddlePart(int n)
        {
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write("-");
                for (int j = 1; j <= n-1; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
        }

        static void PrintLineHeaderFooter(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }
    }
}
