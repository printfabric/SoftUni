using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new[] { " " }
                , StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            numbers.Sort();

            var counter = 0;

            //var num = new List<int>();
            //var index = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = i + 1; j < numbers.Count ; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        counter++;
                        numbers.RemoveAt(j);
                        j--;
                    }

                }
                                
                Console.WriteLine(numbers[i] + " -> " + ++counter);
                counter = 0;
            }
        }
    }
}
