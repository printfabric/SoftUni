using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ArrayHistogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringList = Console.ReadLine()
                .Split(new[] { ' ' }
                , StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var words = new List<string>();
            var occurrenciesCount = new List<int>();

            var wordCount = 1;

            for (int i = 0; i < stringList.Count - 1; i++)
            {
                for (int j = i + 1; j < stringList.Count - 1; j++)
                {
                    if (stringList[i] == stringList[j])
                    {
                        if (words.Contains(stringList[i]))
                        {

                        }

                        wordCount++;
                        stringList.RemoveAt(j);

                    }
                }
               
            }
        }
    }
}
