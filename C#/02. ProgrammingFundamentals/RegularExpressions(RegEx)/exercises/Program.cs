using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var matches = Regex.Matches("Аз съм,,,,, Иван, обаче... ми !!се пие бира", @"\W+");

            foreach (var match in matches)
            {
                Console.WriteLine(match);

            }
        }
    }
}
