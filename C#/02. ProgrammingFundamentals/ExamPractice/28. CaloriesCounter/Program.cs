﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28.CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var totalCalories = 0;


            for (int i = 0; i < n; i++)
            {
                var ingredient = Console.ReadLine().ToLower();
                switch (ingredient)
                {
                    case "cheese":
                        totalCalories += 500;
                        break;
                    case "tomato sauce":
                        totalCalories += 150;
                        break;
                    case "salami":
                        totalCalories += 600;
                        break;
                    case "pepper":
                        totalCalories += 50;
                        break;
                }
            }

            Console.WriteLine("Total calories: {0}", totalCalories);
        }
    }
}
