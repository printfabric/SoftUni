using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {

            var words = Console.ReadLine()
                .Split(new[] { " ", ",", ";", ":", ".", "!", "(", ")", "\"", "'", "\\", "/", "[", "]" }
                , StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var upprerCase = new List<string>();
            var lowerCase = new List<string>();
            var mixedCase = new List<string>();
            
            for (int i = 0; i < words.Count; i++)
            {
                if (Regex.IsMatch(words[i], "[A-Z][A-Z]+"))
                {
                    upprerCase.Add(words[i]);
                }
                else if(Regex.IsMatch(words[i], @"\b[a-z][a-z]+"))
                {
                    lowerCase.Add(words[i]);
                }
                else
                {
                    mixedCase.Add(words[i]);
                }
            }
            Console.WriteLine("Lower-case: " + string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: " + string.Join(", ", upprerCase));
        }
    }
}
