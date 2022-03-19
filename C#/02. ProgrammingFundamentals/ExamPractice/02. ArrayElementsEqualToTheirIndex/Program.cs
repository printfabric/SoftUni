using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ArrayElementsEqualToTheirIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            var integers = Console.ReadLine()
                .Split(new[] { " " }
                , StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < integers.Length; i++)
            {
                if(integers[i] == i)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
