using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Calc_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            string inputParam = (Console.ReadLine());
            string outputParam = (Console.ReadLine());
            
            double lenghtInMeters = lenght;
            if (inputParam == "mm")
            {
                 lenghtInMeters = lenghtInMeters / 1000;
            }
            else if (inputParam == "cm")
            {
                lenghtInMeters = lenghtInMeters / 100;
            }
            else if (inputParam == "mi")
            {
                lenghtInMeters = lenghtInMeters / 0.000621371192;
            }

            else if (inputParam == "in")
            {
                lenghtInMeters = lenghtInMeters / 39.3700787;
            }

            else if (inputParam == "km")
            {
                lenghtInMeters = lenghtInMeters / 0.001;
            }

            else if (inputParam == "ft")
            {
                lenghtInMeters = lenghtInMeters / 3.2808399;
            }

            else if (inputParam == "yd")
            {
                lenghtInMeters = lenghtInMeters / 1.0936133;
            }


            double outputLenght = lenghtInMeters;
            if (outputParam == "mm")
            {
                 lenghtInMeters = lenghtInMeters * 1000;
            }
            else if (outputParam == "cm")
            {
                lenghtInMeters = lenghtInMeters * 100;
            }
            else if (outputParam == "mi")
            {
                lenghtInMeters = lenghtInMeters * 0.000621371192;
            }

            else if (outputParam == "in")
            {
                lenghtInMeters = lenghtInMeters * 39.3700787;
            }

            else if (outputParam == "km")
            {
                lenghtInMeters = lenghtInMeters * 0.001;
            }

            else if (outputParam == "ft")
            {
                lenghtInMeters = lenghtInMeters * 3.2808399;
            }

            else if (outputParam == "yd")
            {
                lenghtInMeters = lenghtInMeters * 1.0936133;
            }
            Console.WriteLine("Convert unit"+ " " + lenghtInMeters);
        }

        

     }
}
