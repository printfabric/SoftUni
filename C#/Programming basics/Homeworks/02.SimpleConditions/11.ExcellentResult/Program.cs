﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellent_Result
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
                if (grade >= 5.50 && grade <= 6.0 )
                {
                   Console.WriteLine("Excellent!");
                }
        }
    }
}
