using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum__Min__Max__Average
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var list = new List<string>();

            for (int i = 0; i < n; i++)
            {
                var num = Console.ReadLine();
                list.Add(num);
            }


            var sum = list.Sum(x => Int32.Parse(x));
            var min = list.Min(x => Int32.Parse(x));
            var max = list.Max(x => Int32.Parse(x));
            var average = list.Average(x => Int32.Parse(x));
            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine("Min = {0}", min);
            Console.WriteLine("Max = {0}", max);
            Console.WriteLine("Average = {0}", average);
        }
    }
}
