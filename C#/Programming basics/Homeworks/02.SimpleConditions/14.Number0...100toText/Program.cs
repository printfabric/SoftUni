﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fromZetoToHundredWithWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine("Zero");
            }

                else if (n == 100)
            {
                Console.WriteLine("one hundred");
            }



            else if (n < 0 || n > 100)
            {
                Console.WriteLine("invalid number");
            }

            else if (n > 0 && n <= 19)
            {
                string[] arrOne = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", 
                                      "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                Console.WriteLine(arrOne[n - 1]);
            }

            else if (n >= 20 && n <= 99)
            {
                if (n == 20 || n == 30 || n == 40 || n == 50 || n == 60 || n == 70 || n == 80 || n == 90)
                {
                    string[] arrTwo = { "twenty", "thirty", "tourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
                    string[] arrOne = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", 
                                      "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                    Console.WriteLine(arrTwo[n / 10 - 2]);
                }
                else
                {

                    string[] arrTwo = { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
                    string[] arrOne = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", 
                                      "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                    Console.WriteLine(arrTwo[n / 10 - 2] + " " + arrOne[n % 10 - 1]);
                }
                
                
                
                    
                

            }
            else if (n >= 100 && n <= 199)
            {
                string[] arrTwo = { "twenty", "thirty", "tourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
                string[] arrOne = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", 
                                      "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                Console.WriteLine("One Hundred " + arrTwo[n % 100 / 10 - 2] + " " + arrOne[n % 10 - 1]);
            }
            else if (n >= 200 && n <= 999)
            {
                string[] arrTwo = { "Zero", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
                string[] arrOne = {"Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve",
                                        "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };

                Console.WriteLine(arrOne[n / 100 - 1] + " " + "Hundred " + arrTwo[n % 100 / 10] + " " + arrOne[n % 10]);
            }
            /* else if (n >= 1000 && n <= 19999)
             {
                 string[] arrTwo = { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
                 string[] arrOne = { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve",
                                         "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"};

                 Console.WriteLine( arrOne[n / 1000 -1] +" Thousand " + "and " + arrOne[n / 1000 -10 ] + " " + "Hundred " + arrTwo[n % 100/10 - 2] +" "+ arrOne[n % 10 -1]);
             }
             else if (n >= 10000 && n <= 999999)
             {
                 string[] arrTwo = { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
                 string[] arrOne = { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve",
                                         "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };

                 Console.WriteLine(arrTwo[n % 10000 /1000 -3] +" "+ arrOne[n % 10000 /1000 -1 ] + " Thousand " + "and " + arrOne[n / 1000 -21] + " " + "Hundred " + arrTwo[n % 100 / 10 - 2] + " " + arrOne[n % 10 - 1]);
            
             } 
             //else if  */

        }

    }
}
