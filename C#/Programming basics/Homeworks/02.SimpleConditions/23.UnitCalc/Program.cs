using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            var unitOne = (Console.ReadLine());
            var unitTwo = (Console.ReadLine());

            if (unitOne == "m")
            {
                if (unitTwo == "mm")
                {
                    Console.WriteLine((num * 1000 + " " +unitTwo));
                }
                else if (unitTwo == "cm")
                {
                    Console.WriteLine((num * 100 + " " + unitTwo));
                }
                else if (unitTwo == "mi")
                {
                    Console.WriteLine((num * 0.000621371192 + " " + unitTwo));
                }
                else if (unitTwo == "in")
                {
                    Console.WriteLine((num * 39.3700787 + " " + unitTwo));
                }
                else if (unitTwo == "km")
                {
                    Console.WriteLine((num * 0.001 + " " + unitTwo));
                }
                else if (unitTwo == "ft")
                {
                    Console.WriteLine((num * 3.2808399 + " " + unitTwo));
                }
                else if (unitTwo == "yd")
                {
                    Console.WriteLine((num * 1.0936133 + " " + unitTwo));
                }
                else if (unitTwo == "m")
                {
                    Console.WriteLine((num * 1));
                }

            }

            else if (unitOne == "mm")
            {
                if (unitTwo == "m")
                {
                    Console.WriteLine((num * 0.001 + " " + unitTwo));
                }
                else if (unitTwo == "mm")
                {
                    Console.WriteLine((num * 1 + " " + unitTwo));
                }
                else if (unitTwo == "cm")
                {
                    Console.WriteLine((num * 0.1 + " " + unitTwo));
                }
                else if (unitTwo == "mi")
                {
                    Console.WriteLine((num * 6.21371192237334e-7 + " " + unitTwo));
                }
                else if (unitTwo == "in")
                {
                    Console.WriteLine((num * 0.039370078740157 + " " + unitTwo));
                }
                else if (unitTwo == "km")
                {
                    Console.WriteLine((num * 1.0E-6 + " " + unitTwo));
                }
                else if (unitTwo == "ft")
                {
                    Console.WriteLine((num * 0.0032808398950131 + " " + unitTwo));
                }
                else if (unitTwo == "yd")
                {
                    Console.WriteLine((num * 0.0010936132983377 + " " + unitTwo));
                }

            }
            else if (unitOne == "cm")
            {
                if (unitTwo == "m")
                {
                    Console.WriteLine((num * 0.01 + " " + unitTwo));
                }
                else if (unitTwo == "cm")
                {
                    Console.WriteLine((num * 1 + " " + unitTwo));
                }
                else if (unitTwo == "mm")
                {
                    Console.WriteLine((num * 10 + " " + unitTwo));
                }
                else if (unitTwo == "mi")
                {
                    Console.WriteLine((num * 6.2137119223733E-6 + " " + unitTwo));
                }
                else if (unitTwo == "in")
                {
                    Console.WriteLine((num * 0.39370078740157 + " " + unitTwo));
                }
                else if (unitTwo == "km")
                {
                    Console.WriteLine((num * 1.0E-5 + " " + unitTwo));
                }
                else if (unitTwo == "ft")
                {
                    Console.WriteLine((num * 0.032808398950131 + " " + unitTwo));
                }
                else if (unitTwo == "yd")
                {
                    Console.WriteLine((num * 0.010936132983377 + " " + unitTwo));
                }

            }

            else if (unitOne == "mi")
            {
                if (unitTwo == "m")
                {
                    Console.WriteLine((num * 1609.344 + " " + unitTwo));
                }
                else if (unitTwo == "mi")
                {
                    Console.WriteLine((num * 1 + " " + unitTwo));
                }
                else if (unitTwo == "mm")
                {
                    Console.WriteLine((num * 1609344 + " " + unitTwo));
                }
                else if (unitTwo == "cm")
                {
                    Console.WriteLine((num * 160934.4 + " " + unitTwo));
                }
                else if (unitTwo == "in")
                {
                    Console.WriteLine((num * 63360 + " " + unitTwo));
                }
                else if (unitTwo == "km")
                {
                    Console.WriteLine((num * 1.609344 + " " + unitTwo));
                }
                else if (unitTwo == "ft")
                {
                    Console.WriteLine((num * 5280 + " " + unitTwo));
                }
                else if (unitTwo == "yd")
                {
                    Console.WriteLine((num * 1760 + " " + unitTwo));
                }

            }

            else if (unitOne == "in")
            {
                if (unitTwo == "m")
                {
                    Console.WriteLine((num * 0.0254 + " " + unitTwo));
                }
                else if (unitTwo == "in")
                {
                    Console.WriteLine((num * 1 + " " + unitTwo));
                }
                else if (unitTwo == "mm")
                {
                    Console.WriteLine((num * 25.4 + " " + unitTwo));
                }
                else if (unitTwo == "cm")
                {
                    Console.WriteLine((num * 2.54 + " " + unitTwo));
                }
                else if (unitTwo == "mi")
                {
                    Console.WriteLine((num * 1.5782828282828E-5 + " " + unitTwo));
                }
                else if (unitTwo == "km")
                {
                    Console.WriteLine((num * 2.54E-5 + " " + unitTwo));
                }
                else if (unitTwo == "ft")
                {
                    Console.WriteLine((num * 0.083333333333333 + " " + unitTwo));
                }
                else if (unitTwo == "yd")
                {
                    Console.WriteLine((num * 0.027777777777778 + " " + unitTwo));
                }

            }

            else if (unitOne == "km")
            {
                if (unitTwo == "m")
                {
                    Console.WriteLine((num * 1000 + " " + unitTwo));
                }
                else if (unitTwo == "km")
                {
                    Console.WriteLine((num * 1 + " " + unitTwo));
                }
                else if (unitTwo == "mm")
                {
                    Console.WriteLine((num * 1000000 + " " + unitTwo));
                }
                else if (unitTwo == "cm")
                {
                    Console.WriteLine((num * 100000 + " " + unitTwo));
                }
                else if (unitTwo == "mi")
                {
                    Console.WriteLine((num * 0.62137119223733 + " " + unitTwo));
                }
                else if (unitTwo == "in")
                {
                    Console.WriteLine((num * 39370.078740157 + " " + unitTwo));
                }
                else if (unitTwo == "ft")
                {
                    Console.WriteLine((num * 3280.8398950131 + " " + unitTwo));
                }
                else if (unitTwo == "yd")
                {
                    Console.WriteLine((num * 1093.6132983377 + " " + unitTwo));
                }

            }

            else if (unitOne == "ft")
            {
                if (unitTwo == "m")
                {
                    Console.WriteLine((num * 0.3048 + " " + unitTwo));
                }
                else if (unitTwo == "ft")
                {
                    Console.WriteLine((num * 1 + " " + unitTwo));
                } 
                else if (unitTwo == "mm")
                {
                    Console.WriteLine((num * 304.8 + " " + unitTwo));
                }
                else if (unitTwo == "cm")
                {
                    Console.WriteLine((num * 30.48 + " " + unitTwo));
                }
                else if (unitTwo == "mi")
                {
                    Console.WriteLine((num * 0.00018939393939394 + " " + unitTwo));
                }
                else if (unitTwo == "in")
                {
                    Console.WriteLine((num * 12 + " " + unitTwo));
                }
                else if (unitTwo == "km")
                {
                    Console.WriteLine((num * 0.0003048 + " " + unitTwo));
                }
                else if (unitTwo == "yd")
                {
                    Console.WriteLine((num * 0.33333333333333 + " " + unitTwo));
                }

            }


            else if (unitOne == "yd")
            {
                if (unitTwo == "m")
                {
                    Console.WriteLine((num * 0.9144 + " " + unitTwo));
                }
                else if (unitTwo == "yd")
                {
                    Console.WriteLine((num * 1 + " " + unitTwo));
                }
                else if (unitTwo == "mm")
                {
                    Console.WriteLine((num * 914.4 + " " + unitTwo));
                }
                else if (unitTwo == "cm")
                {
                    Console.WriteLine((num * 91.44 + " " + unitTwo));
                }
                else if (unitTwo == "mi")
                {
                    Console.WriteLine((num * 0.00056818181818182 + " " + unitTwo));
                }
                else if (unitTwo == "in")
                {
                    Console.WriteLine((num * 36 + " " + unitTwo));
                }
                else if (unitTwo == "km")
                {
                    Console.WriteLine((num * 0.0009144 + " " + unitTwo));
                }
                else if (unitTwo == "ft")
                {
                    Console.WriteLine((num * 3 + " " + unitTwo));
                }
                
            }

           

        }
    }
}
