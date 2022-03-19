using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @return
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = 10;
            var sum = SumNums(p);
            Console.WriteLine(sum);
        }

        static int SumNums(int n)
        {
            return (n + 1) * n / 2;
        }
    }
}
