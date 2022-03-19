using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _15.CountOfCapitalLettersInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split(new[] { " " }
                , StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (Regex.IsMatch(arr[i], "[A-Z]") && arr[i].Length == 1)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
