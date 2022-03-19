using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.DrawAFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            //printHeader
            printHeader(n);
            //printBody
            PrintMiddle(n);
            //printFooter
            printHeader(n);
        }

        private static void PrintMiddle(int n)
        {

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("-");

                for (int j = 0; j < n - 1; j++)
                {
                    Console.Write("\\/");
                }
                Console.Write("-");
                Console.WriteLine();
            }
        }

        private static void printHeader(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }

    }
}
