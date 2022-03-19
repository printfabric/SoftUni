using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            minutes = minutes + 30;

            if(minutes >= 60)
            {
                hours = hours + 1;
                minutes = minutes - 60;

                if (hours > 23)
                {
                    hours = hours - 24;
                }
            }

            Console.WriteLine($"{hours}:{minutes:d2}");

        }
    }
}
