using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            var wordList = Console.ReadLine().Split(new[]
            {',', ';', ':', '.', '!', '(', ')', '"', '\'',
            '\\', '/', '[', ']', ' '}, StringSplitOptions.
            RemoveEmptyEntries).ToList();
            List<string> datalist = new List<string>();
            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCase = new List<string>();
            var isUpper = 0;
            var isLower = 0;
            var counter = 0;

            foreach (string str in wordList)
            {
                datalist.AddRange(wordList[counter].Select(d => d.ToString()));
                counter++;

                for (int j = 0; j < datalist.Count; j++)
                {
                    if (datalist[j].Any(char.IsUpper))
                    {
                        // Console.WriteLine(datalist[j]);
                        isUpper++;
                    }
                    else if (datalist[j].Any(char.IsLower))
                    {
                        // Console.WriteLine(datalist[j]);
                        isLower++;
                    }
                }
                if (isUpper == datalist.Count)
                {

                    for (int i = 0; i < datalist.Count; i++)
                    {
                        upperCase.Add(datalist[i]);

                    }
                    upperCase.Add(", ");

                }
                else if (isLower == datalist.Count)
                {
                    for (int i = 0; i < datalist.Count; i++)
                    {
                        lowerCase.Add(datalist[i]);
                    }
                    lowerCase.Add(", ");
                }
                else
                {
                    for (int i = 0; i < datalist.Count; i++)
                    {
                        mixedCase.Add(datalist[i]);

                    }
                    mixedCase.Add(", ");
                }

                for (int k = datalist.Count - 1; k >= 0; k--)
                {
                    datalist.RemoveAt(k);
                }

                isUpper = 0;
                isLower = 0;
            }
                    
            Console.Write("Lower-case: ");
            for (int i = 0; i < lowerCase.Count - 1; i++)
            {                
                Console.Write(lowerCase[i]);
            }

            Console.WriteLine();
            Console.Write("Mixed-case: ");
            for (int i = 0; i < mixedCase.Count - 1; i++)
            {
                Console.Write(mixedCase[i]);
            }

            Console.WriteLine();
            Console.Write("Upper-case: ");
            for (int i = 0; i < upperCase.Count - 1; i++)
            {
                Console.Write(upperCase[i]);
            }    

        }
    }
}
