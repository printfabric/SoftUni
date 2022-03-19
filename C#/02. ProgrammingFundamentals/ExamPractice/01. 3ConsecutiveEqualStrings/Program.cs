using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._3ConsecutiveEqualStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine()
                .Split(new[] { " " }
                , StringSplitOptions.RemoveEmptyEntries)
                .ToList();            
            list.Reverse();

            for (int i = 0; i < list.Count-2; i++)
            {
                if(list[i] == list[i+1] && list[i+1] == list[i+2])
                {
                    Console.WriteLine($"{list[i]} {list[i+1]} {list[i+2]}");
                    break;
                }
            }
        }
    }
}
