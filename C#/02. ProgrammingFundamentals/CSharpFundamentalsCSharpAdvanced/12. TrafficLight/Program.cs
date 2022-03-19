using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.TrafficLight
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var commands = Console.ReadLine();
            var queue = new Queue<string>();
            var counter = 0;

            while (commands != "end")
            {
                if(commands != "green")
                {
                    queue.Enqueue(commands);
                }
                else if(commands == "green")
                {
                    if(N >= queue.Count)
                    {
                        var queueCount = queue.Count;
                        for (int i = 0; i < queueCount; i++)
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            counter++;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < N; i++)
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            counter++;
                        }
                    }
                }

                commands = Console.ReadLine();
            }

            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
