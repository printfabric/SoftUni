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


            PrintLine(n);

        }

        private static void PrintLine(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                printRow(i);

            }
            for (int i = n - 1; i >= 1; i--)
            {
                printRow(i);

            }
        }

        private static void printRow(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
