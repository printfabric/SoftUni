using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            //var text = Console.ReadLine();

            var text = Console.ReadLine()
                .Split(new string[] { " " }
                , StringSplitOptions.RemoveEmptyEntries);

            Func<string, bool> checker = w => w[0] == w.ToUpper()[0];

            var upperCaseWords = text.Where(checker).ToList();

            foreach (var word in upperCaseWords)
            {
                Console.WriteLine(word);
            }

        }
    }
}
