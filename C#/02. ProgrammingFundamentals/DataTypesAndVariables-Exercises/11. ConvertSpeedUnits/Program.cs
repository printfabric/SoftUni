using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            var distanceInMeters = double.Parse(Console.ReadLine());
            var hours = double.Parse(Console.ReadLine());
            var minutes = double.Parse(Console.ReadLine());
            var seconds = double.Parse(Console.ReadLine());

            double hoursToSeconds = (hours * 60) * 60;
            double minnetsToSeconds = minutes * 60;

            double metersPerSecond = 
                (distanceInMeters / 
                (hoursToSeconds + minnetsToSeconds + seconds));

            double kilometersPerHour = (distanceInMeters / 1000)/(((hoursToSeconds + minnetsToSeconds + seconds) 
                / 60) / 60);

            double milesPerHour = (distanceInMeters * 0.000621371192) / (((hoursToSeconds + minnetsToSeconds + seconds)
                / 60) / 60);

            Console.WriteLine("{0:f6}",metersPerSecond);
            Console.WriteLine("{0:f6}", kilometersPerHour);
            Console.WriteLine("{0:f6}", milesPerHour);
            
            


        }
    }
}
