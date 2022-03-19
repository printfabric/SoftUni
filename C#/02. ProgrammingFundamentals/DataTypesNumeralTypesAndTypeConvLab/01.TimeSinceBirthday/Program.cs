using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TimeSinceBirthday
{
    class Program
    {
        static void Main(string[] args)
        {
            var years = int.Parse(Console.ReadLine());
            var days = 365 * years;
            var hours = 8760 * years;
            var minutes = 525600 * years;
            Console.WriteLine($"{years} years = {days} days = {hours} hours = {minutes} minutes.");
            

           


        }
    }
}
