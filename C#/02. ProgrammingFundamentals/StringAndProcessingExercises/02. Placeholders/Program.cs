using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Placeholders
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] inputParams = inputLine
                    .Split(new[] { '-', '>' }
                , StringSplitOptions.RemoveEmptyEntries);

                string sentence = inputParams[0].Trim();

                string[] elements = inputParams[1]
                    .Trim()
                    .Split(new[] { ',', ' ' }
                , StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < elements.Length; i++)
                {
                    string currentPlaceholder = "{" + i + "}";

                    sentence = sentence.Replace(currentPlaceholder, elements[i]);

                }
                Console.WriteLine(sentence);

                inputLine = Console.ReadLine();
            }
          
        }
    }
}


