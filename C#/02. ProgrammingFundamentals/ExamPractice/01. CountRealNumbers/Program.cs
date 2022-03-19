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
            var numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            var dict = new Dictionary<double, double>();

            foreach (var num in numbers)
            {
                if (dict.ContainsKey(num))
                    dict[num]++;
                else
                    dict[num] = 1;
            }
            //dict.OrderBy(Key)

            //foreach (var item in dict)
            //{
            //    Console.WriteLine(item.Key + "->" + item.Value);
            //}

            var list = dict.Keys.ToList();
            list.Sort();

            // Loop through keys.
            foreach (var key in list)
            {
                Console.WriteLine("{0} -> {1}", key, dict[key] + " times");
            }
        }
    }
}
