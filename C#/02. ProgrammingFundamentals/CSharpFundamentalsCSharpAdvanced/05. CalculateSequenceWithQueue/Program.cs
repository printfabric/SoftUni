using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CalculateSequenceWithQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var counter = 0;
            var newQueue = new Queue<int>();
            var list = new List<int>();
            var S1 = N;
            var S2 = S1 + 1;
            var S3 = 2 * S1 + 1;
            var S4 = S1 + 2;
            var secondCounter = 0;
            newQueue.Enqueue(S1);
            list.Add(S1);
            counter++;


            for (int i = 1; i < 51; i++)
            {
                secondCounter++;
                
                if (counter > 49)
                {
                    break;
                }
                S2 = S1 + 1;
                newQueue.Enqueue(S2);
                list.Add(S2);

                counter++;
                if (counter > 49)
                {
                    break;
                }
                S3 = 2 * S1 + 1;
                newQueue.Enqueue(S3);
                list.Add(S3);

                counter++;
                if (counter > 49)
                {
                    break;
                }
                S4 = S1 + 2;
                newQueue.Enqueue(S4);

                counter++;
                if(counter > 49)
                {
                    break;
                }

                S1 = list[secondCounter]; 
            }

            foreach (var item in newQueue)
            {
                Console.Write(item + " ");
            }
        }
    }
}
