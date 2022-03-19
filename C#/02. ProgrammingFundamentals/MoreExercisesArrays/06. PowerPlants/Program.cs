using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.PowerPlants
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] powerOfPlantsArray = Console.ReadLine().Split(new[] { ' ' },
           StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            //Copy of powerOfPlantsArray  
            int[] powerOfPlantsArrayCopy = new int[powerOfPlantsArray.Length];
            Array.Copy(powerOfPlantsArray, powerOfPlantsArrayCopy, powerOfPlantsArray.Length);

            //powerOfPlantsArrayCopy[1] = powerOfPlantsArrayCopy[1] - 4;

            //Console.WriteLine(powerOfPlantsArrayCopy[1]);
            //Console.WriteLine(powerOfPlantsArray[1]);



            var day = 1;
            var counterDays = 0;
            int sum = 0;
            var end = 100000;
            var season = 0;

            for (int i = 0; i < end; i++)
            {
                if(counterDays == powerOfPlantsArray.Length)
                {
                    for (int h = 0; h < powerOfPlantsArray.Length;h++)
                    {
                        if(powerOfPlantsArrayCopy[h] > 0)
                        {
                            powerOfPlantsArrayCopy[h]++;
                        }
                    }                    
                }

                for (int j = 0; j < powerOfPlantsArray.Length; j++)                {
                   

                    if (powerOfPlantsArrayCopy[j] > 0)
                    {
                        if (powerOfPlantsArray[j] == day)
                        {
                            powerOfPlantsArrayCopy[j] = powerOfPlantsArrayCopy[j] + 1;
                            powerOfPlantsArrayCopy[j] = powerOfPlantsArrayCopy[j] - 1;
                        }
                        else
                        {
                            powerOfPlantsArrayCopy[j] = powerOfPlantsArrayCopy[j] - 1;

                        }
                    }

                    //Console.Write(powerOfPlantsArrayCopy[j] + " ");
                }
                for (int k = 0; k < powerOfPlantsArray.Length; k++)
                {
                    sum = sum + powerOfPlantsArrayCopy[k];
                }
                day++;
                if (day >= powerOfPlantsArray.Length + 2)
                {
                    day = 0;
                }

                //Console.WriteLine();
                if (sum <= 0)
                {

                    end = 1;
                }
                sum = 0;
                                
                counterDays++;
            }
             season++;

            Console.WriteLine("Days {0}", counterDays);
            Console.WriteLine("Season {0}", season);

        }
    }
}
