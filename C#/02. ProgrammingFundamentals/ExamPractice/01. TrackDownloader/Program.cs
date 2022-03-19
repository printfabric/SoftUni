using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.TrackDownloader
{
    class Program
    {
        static void Main(string[] args)
        {
            var blacklistedWords = Console.ReadLine().Split(' ').ToList();

            var input = Console.ReadLine();
            var list = new List<string>();
            while(input != "end")
            {
                if (blacklistedWords.Any(w => input.Contains(w)))
                {

                }
                else
                {
                    list.Add(input);
                }
                input = Console.ReadLine();
            }

            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
