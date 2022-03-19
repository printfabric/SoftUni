using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.StringRepeater
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(str, n));
        }

        static string RepeatString(string str, int n)
        {
            var repeatedString = string.Empty;

            for (int i = 0; i < n; i++)
            {
                repeatedString = repeatedString + str;
            }

            return repeatedString;
        }
    }
}
