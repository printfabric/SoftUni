using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split(new[] { ' ' })
                .Select(double.Parse)
                .ToList();

            var result = new SortedDictionary<double, int>();

            foreach (var number in nums)
            {
                if(!result.ContainsKey(number))
                {
                    result[number] = 0;
                }
                result[number]++;
            }

            foreach(var kvp in result)
            {
                Console.WriteLine(kvp.Key + " -> " + kvp.Value);
                //Console.WriteLine(kvp.Value);
            }
        }


    }
}
