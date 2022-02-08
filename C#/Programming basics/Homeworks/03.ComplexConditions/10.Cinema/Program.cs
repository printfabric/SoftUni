using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var Premiere = 12.00;
            var normal = 7.5;
            var Discount = 5;

             */
            string type = (Console.ReadLine());
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            

            switch (type)
            {
                case "Premiere":
                    Console.WriteLine("{0:f2}", 12.00 * (r * c));
                    break;

                case "Normal":
                    Console.WriteLine("{0:f2}", 7.50 * (r * c));
                    break;
                case "Discount":
                    Console.WriteLine("{0:f2}", 5.00 * (r * c));
                    break;


            }

                        
                    

        }
    }
}
