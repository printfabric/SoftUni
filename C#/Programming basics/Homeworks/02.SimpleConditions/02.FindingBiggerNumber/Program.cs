﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finding_Bigger_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine(num1);
            }

            else if (num1 < num2)
            {
                Console.WriteLine(num2);
            }

            else
            {
                Console.WriteLine(num1);
            }
        }
    }
}
