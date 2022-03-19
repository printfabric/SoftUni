using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Dictionaries_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var wordsList = Console.ReadLine().ToLower().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
            var newList = new List<string>();
            var wordConstance = 1;

            for (int i = 0; i < wordsList.Count; i++)
            {
                for (int j = i + 1; j < wordsList.Count; j++)
                {
                    if(wordsList[i] == wordsList[j])
                    {
                        wordConstance++;
                        wordsList.RemoveAt(j);
                        j--;
                    }
                }

                if(wordConstance % 2 != 0)
                {
                    newList.Add(wordsList[i]);
                }
                wordConstance = 1;
            }

            Console.WriteLine(string.Join(", ", newList));
        }
    }
}
