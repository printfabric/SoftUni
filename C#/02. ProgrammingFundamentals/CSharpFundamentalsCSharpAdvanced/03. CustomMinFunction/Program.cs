using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            Func<List<int>, int> minNumber = GetMin;

            Console.WriteLine(minNumber(numbers));
        }

        public static int GetMin(List<int> numbers)
        {
            var min = int.MaxValue;

            foreach (var num in numbers)
            {
                if(min > num)
                {
                    min = num;
                }
            }
            return min;
        }
    }
}
