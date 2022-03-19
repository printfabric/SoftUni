using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ExactProductOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());
            decimal sum = 1;
            for (decimal i = 0; i < n; i++)
            {
                var num = decimal.Parse(Console.ReadLine());
                sum = sum * num;
            }
            Console.WriteLine(sum);
        }

    }
}
    

