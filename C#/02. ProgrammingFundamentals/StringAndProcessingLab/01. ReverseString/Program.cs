using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();

            var strToChar = str.ToCharArray();
            var strToCharRev = strToChar.Reverse();

            Console.WriteLine(string.Join("", strToCharRev));
        }
    }
}
