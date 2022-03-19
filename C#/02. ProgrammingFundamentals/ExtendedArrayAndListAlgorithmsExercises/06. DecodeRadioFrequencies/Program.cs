using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.DecodeRadioFrequencies
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfDoubles = Console.ReadLine()
                .Split(new[] { ' ', '.' }, StringSplitOptions
                .RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            for (int i = 0; i < listOfDoubles.Count; i++)
            {
                if(i % 2 == 0 && listOfDoubles[i] != 0)
                {
                    Console.Write((char)listOfDoubles[i]);
                }
                
            }

            for (int i = listOfDoubles.Count; i > 0; i--)
            {
                 if (i % 2 != 0 && listOfDoubles[i] != 0)
                {
                    Console.Write((char)listOfDoubles[i]);
                }
            }
        }
    }
}
