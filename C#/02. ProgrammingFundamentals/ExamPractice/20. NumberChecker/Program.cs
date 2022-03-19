using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.NumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int intValue;
            if(int.TryParse(input, out intValue))
            {
                Console.WriteLine("It is a number.");
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
