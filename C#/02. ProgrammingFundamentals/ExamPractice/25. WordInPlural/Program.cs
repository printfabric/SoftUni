using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.WordInPlural
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var endsIn = word.EndsWith("y");

            if(word.EndsWith("y"))
            {
                var newWord = word.Remove(word.Length - 1);
                Console.WriteLine(newWord + "ies");
            }
            else if(word.EndsWith("o") 
                || word.EndsWith("s") 
                || word.EndsWith("x") 
                || word.EndsWith("z") 
                || word.EndsWith("ch") 
                || word.EndsWith("sh"))
            {                
                Console.WriteLine(word + "es");
            }
            else
            {
                Console.WriteLine(word + "s");
            }
           


        }
    }
}
