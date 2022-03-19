using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AverageCharacterDelimiter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] letters = Console.ReadLine()
                     .Split(new char[] { ' ' },
                     StringSplitOptions.RemoveEmptyEntries)
                     .ToArray();

            int sumOfAllChars = 0;
            int allChars = 0;


            foreach (var letter in letters)
            {
                letter.ToCharArray();

                foreach (var let in letter)
                {
                    sumOfAllChars += (int)let;
                    allChars++;
                }
            }

            char delimeter = (char)(sumOfAllChars / allChars);

            Console.WriteLine(string.Join((delimeter
                .ToString()
                .ToUpper()), letters));
        }
    }
}
