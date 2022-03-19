using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.FastPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());

            for (int i = 2; i <= num; i++)
            {
                bool TowaLIE = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        TowaLIE = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {TowaLIE}");
            }


        }
    }
}
