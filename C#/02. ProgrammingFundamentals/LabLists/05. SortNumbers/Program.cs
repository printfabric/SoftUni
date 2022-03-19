using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var decimalNumbers = Console.ReadLine().
                Split(new[] { ' ' }).Select(int.Parse).ToList();
            var counter = 0;
            decimalNumbers.Sort();

            foreach(int number in decimalNumbers)
            {
                counter++;
                Console.Write(number);
                if(counter < decimalNumbers.Count)
                {
                    Console.Write(" <= ");
                }
            }           
        }
    }
}
