using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
           // var regex = @"\b\d{2}(\/|\.|-)[A-Z][a-z]+\1[0-9]{4}\b";
            var regex = @"\b(\d{2})([/|.|-])([A-Z][a-z]{2})\2(\d{4})\b";

            var dateString = Console.ReadLine();

            var dates = Regex.Matches(dateString, regex);

            foreach (Match date in dates)
            {
                var day = date.Groups["1"].Value;
                var month = date.Groups["3"].Value;
                var year = date.Groups["4"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }

            Console.WriteLine();

            var numbers = Regex.Matches(dateString, regex)
                .Cast<Match>()
                .Select(a => a.Value)
                .ToArray();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
