using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TriplesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (var letterFirst = 'a'; letterFirst < 'a' + n; letterFirst++)
            {
                for (var letterSecond = 'a'; letterSecond < 'a' + n; letterSecond++)
                {
                    for (var letterThird = 'a'; letterThird < 'a' + n; letterThird++)
                    {
                        Console.WriteLine("{0}{1}{2}", letterFirst, letterSecond, letterThird);
                    }
                }
            }
        }
    }
}
