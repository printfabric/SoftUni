using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                var num = i;
                var sum = 0;
                if (i < 10)
                {
                    if(i == 5 || i == 7 || i == 11)
                    {
                        Console.WriteLine($"{i} -> True");
                        
                    }
                    else
                    {
                        Console.WriteLine($"{i} -> Faulse");
                        

                    }
                }
                else
                {
                    while(num != 0)
                    {
                        sum += num % 10;
                        num /= 10;
                    }                   

                    if (sum == 5 || sum == 7 || sum == 11)
                    {
                        Console.WriteLine($"{i} -> True");
                    }
                    else
                    {
                        Console.WriteLine($"{i} -> False");
                    }

                }

            }
        }
    }
}
