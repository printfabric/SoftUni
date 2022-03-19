using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FindText
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToLower(); // I like Java and Java programming
            var word = Console.ReadLine().ToLower(); // Java

            var count = 0;
            var lastIndex = -1;
            while (true)
            {
                lastIndex = text.IndexOf(word, lastIndex + 1);
                if (lastIndex != -1)
                {
                    count++;
                    //lastIndex = index;
                }
                else
                    break;
            }
            Console.WriteLine(count);

        }
    }
}
