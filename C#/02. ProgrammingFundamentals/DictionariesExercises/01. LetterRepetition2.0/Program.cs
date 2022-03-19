using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LetterRepetition2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleString = Console.ReadLine();

            var charCount = new Dictionary<char, int>();

            foreach (var charecter in singleString)
            {
                if(!charCount.ContainsKey(charecter))
                {
                    charCount[charecter] = 0;
                }
                charCount[charecter]++;
            }

            foreach (var kvp in charCount)
            {
                Console.WriteLine(kvp.Key + " -> " + kvp.Value);
            }
        }
    }
}
