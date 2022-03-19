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
            var value = Console.ReadLine();
            var array = value.ToCharArray();

            

            var dict = new Dictionary<char, int>();

            foreach (var num in array)
            {
                if (dict.ContainsKey(num))
                    dict[num]++;
                else
                    dict[num] = 1;
            }

            foreach (var let in dict)
            {
                Console.WriteLine(let.Key + " -> " + let.Value);
            }
        }
    }
}
