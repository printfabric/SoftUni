using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine()
                .Split(new[] { ',', '?', '!', ' ', '.', '-' }
                ,StringSplitOptions.RemoveEmptyEntries);
            var newList = new List<string>();

            foreach (var word in text)
            {
                var charWord = word.ToCharArray();
                var charWordReverse = charWord.Reverse().ToArray();
                var charWordReverseStr = new string(charWordReverse);

                if (charWordReverseStr == word)
                {
                    newList.Add(word);
                }
            }

            newList.Sort();
            Console.WriteLine(string.Join(", ", newList));
        }
    }
}
