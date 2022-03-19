using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int holiDays = int.Parse(Console.ReadLine());
            var days = 365;
            var workDays = days - holiDays;
            int gamePlay = (workDays * 63) + (holiDays * 127);
            int diff =Math.Abs(30000 - gamePlay);
            int hours = diff / 60;
            int minutes = diff % 60;
                     
                        
            
            
            if (gamePlay <= 30000)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine(hours + " hours and " + minutes + " minutes less for play");
                
            }

            else if (gamePlay > 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine(hours + " hours and " + minutes + " minutes more for play");
            }

            
        }
    }
}
