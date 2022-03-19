using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44.TimeSinceBirthday
{
    class Program
    {
        static void Main(string[] args)
        {
            var years = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} Years = {1} days = {2} hours = {3} minutes.",
               years, (years * 365), (years * 365 * 24), (years * 365 * 24 * 60), (years * 365 * 24 * 60 * 60));
        }
    }
}
