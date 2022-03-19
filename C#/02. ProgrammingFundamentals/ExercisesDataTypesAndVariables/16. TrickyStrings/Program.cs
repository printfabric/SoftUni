using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.TrickyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string delimeter = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());
            var playerName = "";

            for (int i = 0; i < n - 1; i++)
            {
                string array = Console.ReadLine();
                playerName = playerName + array + delimeter;
            }
            string arrayLast = Console.ReadLine();
            Console.WriteLine(playerName + arrayLast);
        }
    }
}
