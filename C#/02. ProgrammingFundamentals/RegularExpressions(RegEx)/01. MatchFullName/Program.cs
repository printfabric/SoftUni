using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            var names = Console.ReadLine();

            MatchCollection matchesNames = Regex.Matches(names, regex);


            foreach (Match name in matchesNames)
            {
                Console.Write(name.Value + " ");

            }
            Console.WriteLine();
        }
    }
}
