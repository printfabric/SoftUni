using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RemoveElementsAtOddPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int i = 0; i < list.Count; i++)
            {
                if(i % 2 != 0)
                {
                    Console.Write(list[i]);
                }
            }
        }
    }
}
