using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NumbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine();
            RevurseDigitsOfNUmber(num);            
        }

        static void RevurseDigitsOfNUmber(string num)
        {
            char[] cArray = num.ToCharArray();
            string reverse = String.Empty;

            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }

            Console.WriteLine(reverse);
        }
    }
}
