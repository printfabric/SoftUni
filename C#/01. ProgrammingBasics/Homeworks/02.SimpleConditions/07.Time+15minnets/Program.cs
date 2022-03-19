using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Time_15minnets
{
    class Program
    {
        static void Main(string[] args)
        {


            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int minutesPlus = minutes + 15;
            int minutesPlusMinus = minutesPlus - 60;
            int hoursPlus = hours +1;
            int hoursPlusMinus = hoursPlus - 24;
           
            
            if (minutesPlus > 59 && minutesPlusMinus < 10)
            {
                if (hoursPlus > 23)
                    Console.WriteLine(hoursPlusMinus + ":" + 0 + minutesPlusMinus);
               else  
                {
                    Console.WriteLine(hoursPlus + ":" + 0 + minutesPlusMinus);
                }
               

            }
            
            else if (minutesPlus > 59 && minutesPlusMinus >= 10)
            {
                if (hoursPlus > 23)
                    Console.WriteLine(hoursPlusMinus + ":"  + minutesPlusMinus);
                else
                {
                    Console.WriteLine(hoursPlus + ":" + minutesPlusMinus);
                }                             
            }

            else
            {
                Console.WriteLine(hours + ":" + minutesPlus);
            }


            

        }
    }
}
