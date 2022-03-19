using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ASCIIString
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            string result = "";

            for (int i = 0; i < n; i++)
            {
                int asciiCode = int.Parse(Console.ReadLine());
                char charecter = (char)asciiCode;
                // Console.WriteLine((char)N);
                result += charecter;

            }
            Console.WriteLine(result);
        }
    }
}
