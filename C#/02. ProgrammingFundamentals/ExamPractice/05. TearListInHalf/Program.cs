using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.TearListInHalf
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(new[] { ' ' }).Select(int.Parse).ToList();

            for (int i = 0; i < list.Count /2; i++)
            {
                Console.Write((list[(list.Count / 2) + i]) / 10);
                Console.Write(" " + list[i] + " ");
                Console.Write((list[(list.Count / 2) + i]) % 10);
                Console.Write(" ");
            }
        }
    }
}
