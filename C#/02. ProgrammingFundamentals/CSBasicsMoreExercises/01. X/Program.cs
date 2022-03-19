using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.X
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var spacesInc = 0;
            var spacesDec = n - 2;


            for (int i = 1; i <= (n - 1) / 2; i++)
            {
                Console.Write(new string(' ', spacesInc));
                Console.Write('x');
                Console.Write(new string(' ', spacesDec));
                Console.Write('x');
                Console.WriteLine();
                spacesDec -= 2;
                spacesInc++;
            }

            Console.Write(new string(' ', (n-1) / 2));
            Console.Write("x");
            Console.Write(new string(' ', (n-1) / 2));
            Console.WriteLine();
           
            for (int i = 1; i <= (n - 1) / 2; i++)
            {
                spacesInc--;
                spacesDec += 2;
                Console.Write(new string(' ', spacesInc));
                Console.Write('x');
                Console.Write(new string(' ', spacesDec));
                Console.Write('x');
                Console.WriteLine();
              
            }

        }
    }
}
