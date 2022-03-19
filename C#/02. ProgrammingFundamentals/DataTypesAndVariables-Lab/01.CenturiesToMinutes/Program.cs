using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var centuriesNum = int.Parse(Console.ReadLine());
            var years = centuriesNum * 100;
            var days = (int)(years * 365.2422);
            var hours = days * 24;
            var minutes = hours * 60;

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes", centuriesNum, years, days, hours, minutes);


           
        }
    }
}
