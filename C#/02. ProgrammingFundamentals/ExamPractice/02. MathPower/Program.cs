using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var power = int.Parse(Console.ReadLine());
            var powered = 1;
            Console.WriteLine(PoweringNumber(num, power, powered));
        }

        static int PoweringNumber(int num, int power, int powered)
        {
            for (int i = 0; i < power; i++)
            {
                powered = powered * num;
            }
            return powered;
        }
    }
}
