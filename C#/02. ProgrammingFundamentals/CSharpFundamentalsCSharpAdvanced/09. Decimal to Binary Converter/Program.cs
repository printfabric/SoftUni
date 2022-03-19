using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Decimal_to_Binary_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputDecimal = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();

            if(inputDecimal == 0)
            {
                stack.Push(0);
            }
            while(inputDecimal != 0)
            {
                var residue = inputDecimal % 2;
                stack.Push(residue);
                inputDecimal = Math.Abs(inputDecimal / 2);
            }

            Console.WriteLine(string.Join("", stack));
        }
    }
}
