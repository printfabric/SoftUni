using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            var power = int.Parse(Console.ReadLine());

            Console.WriteLine(RaiseToPower(number, power));


        }

        static double RaiseToPower(double number, int power)
        {
            double result = 1d;

            for (int i = 0; i < power; i++)
            {
                result = number * result;
            }

            return result;
           // Console.WriteLine(result);
        }
    }
}
