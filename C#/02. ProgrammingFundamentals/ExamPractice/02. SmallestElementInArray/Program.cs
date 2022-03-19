using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SmallestElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new[] { ' ' })
                .Select(int.Parse)
                .ToList();
            var smallest = 1000000;
            for (int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] < smallest)
                {
                    smallest = numbers[i];
                }
            }
            Console.WriteLine(smallest);
        }
    }
}
