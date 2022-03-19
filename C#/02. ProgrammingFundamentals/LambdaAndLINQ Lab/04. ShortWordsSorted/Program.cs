using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToLower()
                .Split(new[] { ".", ",", ":", "(", ")", "["
                , "]", "'", "\\", "/", "!", "?", "\"", " " }
                , StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var ordered = text.Where(p => p.Length < 5)
                .OrderBy(p => p).Distinct().ToList();

                // sort by number of chars
                //.OrderBy(p => p.Length).Distinct().ToList();


            //ordered = text.OrderBy(p => p.Length);


            Console.WriteLine(string.Join(", ", ordered));
            
        }
    }
}
