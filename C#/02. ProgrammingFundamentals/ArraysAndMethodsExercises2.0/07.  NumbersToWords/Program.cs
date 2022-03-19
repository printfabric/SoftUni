using System;
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
            var num = int.Parse(Console.ReadLine());
            Letterize(num);            
        }

        static void Letterize(int num)
        {
            

            for (int i = 0; i < num; i++)
            {
                var n = int.Parse(Console.ReadLine());
                var sign = "";
                string[] arrTwo = { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety", "" };
                string[] arrOne = {"", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten",
                "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty"};

                if (n < 0)
                {
                    sign = "minus ";
                }
                if (n < -999 || n > 999)
                {
                    if (n < -999)
                    {
                        Console.WriteLine("too small");
                        break;
                    }
                    else if (n > 999)
                    {
                        Console.WriteLine("too large");
                        break;
                    }
                }

                else /*if(n > -1000 && n < 1000)*/
                {
                    n = Math.Abs(n);

                    if (n > 0 && n < 100)
                    {

                    }

                    else
                    {
                        if ((n / 10) % 10 == 0 && n % 10 == 0)
                        {
                            Console.WriteLine($"{sign}" + arrOne[n / 100] + "-hundred");
                        }
                        else if (n % 10 == 0)
                        {
                            Console.WriteLine($"{sign}" + arrOne[n / 100] + "-hundred and " + arrTwo[(n % 100 / 10) - 2]);
                        }
                        else
                        {
                            if (n % 20 == 0)
                            {

                                if ((n / 10) % 10 == 0)
                                {
                                    Console.WriteLine($"{sign}" + arrOne[n / 100] + "-hundred and " + arrOne[n % 100 / 10] + " " + arrOne[n % 10]);
                                }
                                else
                                {
                                    Console.WriteLine($"{sign}" + arrOne[n / 100] + "-hundred and " + arrTwo[n % 100 / 10 - 1] + " " + arrOne[n % 10]);

                                }
                            }
                            else
                            {
                                if ((n / 10) % 10 == 0)
                                {
                                    Console.WriteLine($"{sign}" + arrOne[n / 100] + "-hundred and " + arrOne[n / 10 - 1]);
                                }
                                else if ((n / 10) % 10 == 1)
                                {
                                    Console.WriteLine($"{sign}" + arrOne[n / 100] + "-hundred and " + arrOne[n % 100]);

                                }
                                else
                                {
                                    Console.WriteLine($"{sign}" + arrOne[n / 100] + "-hundred and " + arrTwo[n % 100 / 10 - 2] + " " + arrOne[n % 10]);

                                }

                            }
                        }
                    }
                }


            }
            
        }
    }
}


