using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Batteries
{
    class Program
    {
        static void Main(string[] args)
        {
            var batteriesCapacity = Console.ReadLine()
                .Split(new[] { ' ' })
                .Select(decimal.Parse)
                .ToList();

            var usagePerHour = Console.ReadLine()
                 .Split(new[] { ' ' })
                 .Select(decimal.Parse)
                 .ToList();

            var hours = int.Parse(Console.ReadLine());


            var usage = new List<decimal>();
            usage.Add(0);
            usage.Add(0);
            usage.Add(0);
            usage.Add(0);



            var counter = 0;
            var secondCounter = 0;

            for (int i = 0; i < batteriesCapacity.Count ; i++)
            {
                for (int j = 0; j < hours; j++)
                {
                    if (batteriesCapacity[i] > 0)
                    {
                        batteriesCapacity[i] = batteriesCapacity[i] - usagePerHour[i];
                        usage[i] = usage[i] + usagePerHour[i];
                    }
                    else
                    {
                        Console.WriteLine($"Battery {i+1}: dead (lasted {counter} hours)");
                        secondCounter++;
                        break;
                    }
                    counter++;

                }
                if (secondCounter == 0)
                {
                    var capacity = (batteriesCapacity[i] / (usage[i] + batteriesCapacity[i])) * 100;
                    Console.WriteLine($"Battery {i+1}: {batteriesCapacity[i]:f2} mAh ({capacity:f2})");
                }

                secondCounter = 0;
                counter = 0;
            }

            
        }
    }
}
