using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LetterRepetition
{
    class Program
    {
        static void Main(string[] args)
        {
            var chars = Console.ReadLine();           

            List<string> charList = chars.Select(c => c.ToString()).ToList();

            var result = new Dictionary<string, int>();

            foreach (var letter in charList)
            {
                if (!result.ContainsKey(letter))
                {
                    result[letter] = 0;
                }
                result[letter]++;
            }

            foreach (var kvp in result)
            {
                Console.WriteLine(kvp.Key + " -> " + kvp.Value);
                //Console.WriteLine(kvp.Value);
            }


        }
    }
}
