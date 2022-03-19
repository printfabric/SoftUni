using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.RefactorSpecialsumbers
{
    class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            int naxNumber = int.Parse(Console.ReadLine());            
            int currentNumber = 0;           

            for (int i = 1; i <= naxNumber; i++)
            {
                currentNumber = i;
                var sum = 0;
                while (currentNumber > 0)
                {
                    
                    sum += currentNumber % 10;
                    currentNumber = currentNumber / 10;
                }

               var result = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{i} -> {result}");
            }
        }
    }
}

