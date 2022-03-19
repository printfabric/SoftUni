using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.CountOfCapitalLettersInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            int countUpper = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                if (char.IsUpper(sentence[i])) countUpper++;
            }

            Console.WriteLine(countUpper);
        }
    }
}
