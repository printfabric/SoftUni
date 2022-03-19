using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _14.IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var hex = Convert.ToString(number, 16);            
            string hexString = (hex).ToUpper();         
            
            
            Console.WriteLine(hexString);
            Console.WriteLine(Convert.ToString((number), 2));


        }
    }
}
