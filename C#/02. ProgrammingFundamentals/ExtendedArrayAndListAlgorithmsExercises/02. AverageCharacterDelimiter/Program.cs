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
            var strings = Console.ReadLine()
                .Split(new[] {" "}
                ,StringSplitOptions.RemoveEmptyEntries)                                
                .ToArray();
            var sum = 0;
            var counter = 0;

            //Find sum of chars in strings array
            for (int i = 0; i < strings.Length; i++)
            {                
                char[] charArr;
                charArr = strings[i].ToCharArray();

                for (int j = 0; j < charArr.Length; j++)
                {
                    sum = sum + charArr[j];
                    counter++;
                }   
                            
            }         

            var averageSum = (sum / counter);
            for (int i = 0; i < strings.Length; i++)
            {
                Console.Write(strings[i]);
                if (i < strings.Length -1)
                {
                    if (averageSum >= 97 && averageSum <= 123)
                    {
                        Console.Write((char)(averageSum - 32));
                    }
                    else
                    {
                        Console.Write((char)averageSum);
                    }
                }
            }
        }
    }
}
