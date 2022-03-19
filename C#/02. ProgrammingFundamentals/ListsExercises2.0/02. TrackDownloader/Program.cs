using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TrackDownloader
{
    class Program
    {
        static void Main(string[] args)
        {
            var blacklistedWords = Console.ReadLine().Split(new[] { ' ' }).ToList();
            var filenames = new List<string>();
            var endLoop = 100;

            for (int i = 0; i < endLoop; i++)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    endLoop = 0;
                }
                else
                {
                    filenames.Add(input);
                }
            }

            filenames.Sort();
            for (int i = 0; i < blacklistedWords.Count; i++)
            {
                for (int j = 0; j < filenames.Count; j++)
                {
                    if (filenames[j].Contains(blacklistedWords[i]))
                    {
                        filenames.RemoveAt(j);
                        j--;
                    }
                }
            }

            for (int i = 0; i < filenames.Count; i++)
            {
                Console.WriteLine(filenames[i]);
            }  
                       
        }
    }
}
