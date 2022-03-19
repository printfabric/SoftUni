using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ArrayContainsElement
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfIntegers = Console.ReadLine()
                .Split(new[] { ' ' })
                .Select(int.Parse)
                .ToList();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < listOfIntegers.Count; i++)
            {
                if (listOfIntegers[i] == n)
                {
                    Console.WriteLine("yes");
                    return;
                }
                else if (i == listOfIntegers.Count - 1)
                {
                    Console.WriteLine("no");
                    return;                    
                }
            }
        }
    }
}
