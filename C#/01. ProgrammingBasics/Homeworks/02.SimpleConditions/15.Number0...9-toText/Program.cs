using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_0._._._9_toText
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n > 0 && n <= 9)
            {
                string[] arrOne = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
                Console.WriteLine(arrOne[n - 1]);
            }
            else
            {
                Console.WriteLine("number too big");
            }
        }
    }
}
