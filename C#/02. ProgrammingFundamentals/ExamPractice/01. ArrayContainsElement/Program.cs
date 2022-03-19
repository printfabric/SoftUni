using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ArrayContainsElement
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new[] { ' ' })
                .Select(int.Parse)
                .ToList();

            var num = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] == num)
                {
                    Console.WriteLine("yes");
                    goto end;
                }
            }

            Console.WriteLine("no");
            end:;

        }
    }
}
