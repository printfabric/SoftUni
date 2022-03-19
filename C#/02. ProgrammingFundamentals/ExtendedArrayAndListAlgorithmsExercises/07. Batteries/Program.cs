using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Batteries
{
    class Program
    {
        static void Main(string[] args)
        {
            var batteryBatch = Console.ReadLine()
                .Split(new[] { ' ' })
                .Select(double.Parse)
                .ToList();
            var batteryLife = Console.ReadLine()
                .Split(new[] { ' ' })
                .Select(double.Parse)
                .ToList();
            var testingHours = int.Parse(Console.ReadLine());
            var counter = 0;
            var empty = 0.0;

            for (int i = 0; i < batteryBatch.Count; i++)
            {
                for (int j  = 0; j < testingHours ; j++)
                {
                    batteryBatch[i] = batteryBatch[i] - batteryLife[i];
                    empty = empty + batteryLife[i];
                    counter++;
                    if (batteryBatch[i] <= 0)
                    {
                        Console.WriteLine("Battery " + (i + 1) + $": dead (lasted {counter} hours)");
                        break;
                    }                        
                }

                if(batteryBatch[i] > 0)
                {
                    var percentage = (batteryBatch[i] / (empty + batteryBatch[i])) * 100;
                    Console.WriteLine("Battery "+ (i+1) + ": {0:f2} mAh ({1:f2})%", batteryBatch[i], percentage);
                }
                counter = 0;
                empty = 0;
            }            

        }
    }
}
