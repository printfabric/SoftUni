using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string timeDayNight = (Console.ReadLine());

            if (n >= 20 && n < 100)
            {
                if (timeDayNight == "day")
                {
                    Console.WriteLine("day " + n * 0.09);
                }
                else if (timeDayNight == "night")
                {
                    Console.WriteLine("night " + n * 0.09);
                }
                
            }
            else if (n >= 100)
            {
                if (timeDayNight == "day")
                {
                    Console.WriteLine("day " + n * 0.06 );
                }
                else if (timeDayNight == "night")
                {
                    Console.WriteLine("night " + n * 0.06 );
                }

            }
            else if (n < 20)
            {
                if (timeDayNight == "day")
                {
                    Console.WriteLine("day " + ((n * 0.79) + 0.70));
                }
                else if (timeDayNight == "night")
                {
                    Console.WriteLine("night " + ((n * 0.90) + 0.70));
                }
                
            }





        }
    }
}
