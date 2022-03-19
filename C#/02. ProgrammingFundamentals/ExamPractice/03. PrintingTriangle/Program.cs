using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int j  = 0; j <= n; j++)
            {
                PrintTrianglee(n, j);
                Console.WriteLine();
            }

            for (int j = n-1; j >= 1; j--)
            {
                PrintTrianglee(n, j);
                Console.WriteLine();
            }

        }

        private static void PrintTrianglee(int n, int j)
        {
            for (int i = 1; i <= j; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
