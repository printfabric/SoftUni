using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Same_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = (Console.ReadLine());
            string wordTwo = (Console.ReadLine());

            string lowerWord = word.ToLower();
            string lowerWordTwo = wordTwo.ToLower();

            if (lowerWord == lowerWordTwo)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
           
             
          


        }
    }
}
