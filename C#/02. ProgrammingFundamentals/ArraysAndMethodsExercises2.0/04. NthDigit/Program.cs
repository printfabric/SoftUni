using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NthDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var index = int.Parse(Console.ReadLine());
            FindNthDigit(number, index);
        }

        static void FindNthDigit(int number, int index)
        {            
            for (int i = 1; i < index; i++)
            {
                number = number / 10;
                Console.WriteLine(number);                     
            }
            
            Console.WriteLine(number % 10);
        }
    }
}
