using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.CountOccurrencesOfLargerNumbersInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] newArray = Console.ReadLine().Split(new[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            var num = double.Parse(Console.ReadLine());
            var counter = 0;

            for (int i = 0; i < newArray.Length; i++)
            {
                if (newArray[i] > num)
                {
                    counter += 1;
                }
            }

            Console.WriteLine(counter);

        }
    }
}