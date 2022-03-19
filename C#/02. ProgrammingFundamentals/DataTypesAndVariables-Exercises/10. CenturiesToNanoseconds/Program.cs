using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CenturiesToNanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var centuriesNum = int.Parse(Console.ReadLine());
            var addDay = 0;
            var years = centuriesNum * 100;

            if (centuriesNum >= 5)
            {
                addDay = (int)(centuriesNum / 5);
                var days = (centuriesNum * 36524) + addDay;
                var hours = days * 24;
                var minutes = hours * 60;
                decimal seconds = minutes * 60m;
                decimal milliseconds = seconds * 1000m;
                decimal microseconds = milliseconds * 1000m;
                decimal nanoseconds = microseconds * 1000m;
                Console.WriteLine($"{centuriesNum} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
                               
            }
            else if (centuriesNum % 5 != 0)
            {
                var days = centuriesNum * 36524;
                var hours = days * 24;
                var minutes = hours * 60;
                decimal seconds = minutes * 60m;
                decimal milliseconds = seconds * 1000m;
                decimal microseconds = milliseconds * 1000m;
                decimal nanoseconds = microseconds * 1000m;
                Console.WriteLine($"{centuriesNum} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
            }
        }
    }
}
