using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterMulticurrency
{
    class Program
    {

        static double convert(string a)
        {
            switch (a)
            {
                case "BGN":
                    return 1;
                    break;
                case "USD":
                    return 1.79549;
                    break;
                case "EUR":
                    return 1.95583;
                case "GBP":
                    return 2.53405;
                    break;
                default:
                    return 1;
                    break;
            }
        }
        static void Main()
        {
            var amount = double.Parse(Console.ReadLine());
            string currency_1 = Console.ReadLine();
            string currency_2 = Console.ReadLine();

            double value1 = convert(currency_1);
            double value2 = convert(currency_2);

            double result = (value1 / value2) * amount;
            Console.WriteLine(Math.Round(result, 2) + " " + currency_2);


        }
    }
}        
    

