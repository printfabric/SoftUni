﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));
                Console.Write("*");

                for (int j = 1; j < i; j++)
                {
                    Console.Write(" *");   
                }
                Console.WriteLine();
            }

            for (int i = 0; i <= n - 1; i++)
            {
                Console.Write(new string(' ', i));
                for (int j = 1; j < n - i; j++)
                {
                    Console.Write(" *");
                    
                }
                Console.WriteLine();


            }
            
        }
    }
}
