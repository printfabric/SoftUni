using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36.X
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var increase = 0;
            var decrease = n - 2;

            for (int i = 0; i < n/2; i++)
            {
                Console.Write(new string(' ', increase));
                Console.Write("x");
                Console.Write(new string(' ', decrease));
                Console.Write("x");
                Console.WriteLine();
                increase++;
                decrease -= 2;
            }

            Console.Write(new string(' ', increase));
            Console.Write("x");
            Console.WriteLine();

            increase--;
            decrease += 2;

            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string(' ', increase));
                Console.Write("x");
                Console.Write(new string(' ', decrease));
                Console.Write("x");
                Console.WriteLine();
                increase--;
                decrease += 2;
            }

        }
    }
}
