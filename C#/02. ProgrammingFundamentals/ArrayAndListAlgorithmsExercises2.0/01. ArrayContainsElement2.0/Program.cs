using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ArrayContainsElement2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new[] { ' ' })
                .Select(int.Parse)
                .ToArray();
            var numberToFind = int.Parse(Console.ReadLine());            

            var found = false;
            foreach (int number in numbers)
            {
                if (number == numberToFind)
                {
                    found = true;
                    Console.WriteLine("yes");
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("no");
            }
        }
    }
}
