﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.StringRepeater
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringToRepeat = Console.ReadLine();
            var count = int.Parse(Console.ReadLine());
            string result = RepeatString(stringToRepeat, count);
            Console.WriteLine(result);
            //RepeatString(st, count);
        }

         static string RepeatString(string str, int count) 
        {
            string repeatedString = string.Empty;
            

            for (int i = 0; i < count; i++)
            {
                repeatedString += str;
                
            }

            return repeatedString;
        }
    }
}
