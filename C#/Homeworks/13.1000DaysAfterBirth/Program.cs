using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _13._1000DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateStr = Console.ReadLine();
            DateTime myDays = DateTime.ParseExact(dateStr, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(myDays.AddDays(999).ToString("dd-MM-yyyy"));

            // Console.WriteLine("Enter date of Birth in format DD-MM-YYYY: ");      
            //  myDays = DateTime.Parse(Console.ReadLine());
            //  Console.WriteLine(myDays.AddDays(999).ToString("dd-MM-yyyy"));



        }
    }
}
