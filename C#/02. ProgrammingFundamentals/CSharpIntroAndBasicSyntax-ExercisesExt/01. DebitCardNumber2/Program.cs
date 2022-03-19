using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DebitCardNumber2
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOne = int.Parse(Console.ReadLine());
            var numberTwo = int.Parse(Console.ReadLine());
            var numberThree = int.Parse(Console.ReadLine());
            var numberFour = int.Parse(Console.ReadLine());

            Console.Write("{0:d4} ", numberOne);
            Console.Write("{0:d4} ", numberTwo);
            Console.Write("{0:d4} ", numberThree);
            Console.Write("{0:d4}", numberFour);

        }
    }
}
