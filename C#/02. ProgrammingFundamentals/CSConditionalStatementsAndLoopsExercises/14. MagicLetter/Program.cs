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
            
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());

            for (var letterFirst = a; letterFirst <= b; letterFirst++)
            {
                for (var letterSecond = a; letterSecond <= b; letterSecond++)
                {
                    for (var letterThird = a; letterThird <= b; letterThird++)
                    {
                        if (letterFirst == c || letterSecond == c || letterThird == c)
                        {

                        }
                        else
                        {
                            Console.Write("{0}{1}{2} ", letterFirst, letterSecond, letterThird);
                        }
                    }
                }
            }
        }
    }
}