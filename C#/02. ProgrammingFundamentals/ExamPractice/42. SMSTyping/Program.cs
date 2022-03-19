using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42.SMSTyping
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num == 0)
                {
                    Console.Write(" ");
                }
                else
                {
                    var numberOfDigits = Math.Ceiling(Math.Log10(num));
                    var mainDigit = num % 10;
                    var numberOffset = 0;

                    if (mainDigit == 8 || mainDigit == 9)
                    {
                        numberOffset = ((mainDigit - 2) * 3) + 1;
                    }
                    else
                    {
                        numberOffset = (mainDigit - 2) * 3;
                    }

                    var letterIndex = (numberOffset + numberOfDigits - 1);

                    Console.Write((char)(letterIndex + 97));
                }
            }

        }
    }
}
