using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29.CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int intValue;
            var counter = 0;
           
           while(int.TryParse(input, out intValue))
            {
                counter++;
                input = Console.ReadLine();
            }
            Console.WriteLine(counter);
        }
    }
}
