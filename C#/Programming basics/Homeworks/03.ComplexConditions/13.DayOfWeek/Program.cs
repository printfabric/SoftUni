using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());

            if (day >= 1 && day <= 7)
            {
                string[] arr = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
                Console.WriteLine(arr[day - 1] + " ");    
            }

            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}


