using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter_USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.Write("USD = ");
            var BGN = double.Parse(Console.ReadLine());            
            var USD = BGN * 1.79549;
            double USDRound = Math.Round(USD, 2);
          //  Console.Write("BGN = ");
            Console.WriteLine(USDRound + " BGN");
        }
    }
}
