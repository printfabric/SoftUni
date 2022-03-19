using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MathPower
{
    class Program
    {  
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            var power = double.Parse(Console.ReadLine());

            PoweringNumber(number, power);
        }

         static void PoweringNumber(double number, double power)
        {
            var emptyMempty = number;
            for (int i = 1; i < power; i++)
            {
                number = emptyMempty * number;
            }
            Console.WriteLine(number);
        }
    }
}
