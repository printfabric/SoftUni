using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.IncrementVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            byte variable = 0;
            int times = 0;
            for (int i = 0; i < n; i++)
            {
                variable++;
                if(variable == 0)
                {
                    times++; 
                }
            }

            Console.WriteLine(variable);
            Console.WriteLine("Overflowed {0} times", times);
                
        }
    }
}
