﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            if (age < 16)
            {
                if (gender == "f")
                {
                    Console.WriteLine("Miss");
                }
                else if (gender == "m")
                {
                    Console.WriteLine("Master");
                }
            }
            if (age >= 16)
            {
                if (gender == "f")
                {
                    Console.WriteLine("Ms.");
                }
                else if (gender == "m")
                {
                    Console.WriteLine("Mr.");
                }
            }



        }
    }
}
