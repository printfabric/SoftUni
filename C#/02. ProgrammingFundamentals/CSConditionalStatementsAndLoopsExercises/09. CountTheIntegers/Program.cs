﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            try
            {                
                for (int i = 1; i > 0; i++)
                {
                    var number = int.Parse(Console.ReadLine());
                    count++;
                }                                
            }

            catch (Exception)
            {
                Console.WriteLine(count);
            }
        }
    }
}
