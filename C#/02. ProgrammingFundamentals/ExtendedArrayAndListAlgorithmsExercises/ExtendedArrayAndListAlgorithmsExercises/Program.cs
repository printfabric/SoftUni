using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendedArrayAndListAlgorithmsExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            var shootList = new List<int>();

            var stop = false;
            var empty = 0;

            while (stop == false)
            {
                var input = Console.ReadLine();

                if (input == "stop")
                {

                    Console.WriteLine("survivors: " + string.Join(" ", shootList));
                    stop = true;
                }
                else if (input == "bang")
                {
                    double averageNumber = shootList.Average();
                    var count = 0;
                    for (int i = 0; i < shootList.Count; i++)
                    {
                        if (shootList[i] <= averageNumber && shootList.Count > 0)
                        {
                            Console.WriteLine("shot {0}", shootList[i]);
                            empty = shootList[i];
                            shootList.RemoveAt(i);
                            count++;
                            i = shootList.Count;
                            //break;
                        }
                        if(shootList.Count < 1)
                        {
                            //Console.WriteLine("shot {0}", empty);
                            Console.WriteLine($"nobody left to shoot! last one was {empty}");
                               return;
                        }
                        else if ((count == 0) && (i == shootList.Count - 1))
                        {
                            Console.WriteLine("shot {0}", shootList[i]);
                            Console.WriteLine($"you shot them all. last one was {shootList[i]}");
                            return;
                        }
                    }
                    for (int i = 0; i < shootList.Count; i++)
                    {
                        shootList[i] = shootList[i] - 1;
                    }


                }
                else
                {
                    int x = 0;
                    int.TryParse(input, out x);
                    shootList.Insert(0, x);
                }

            }
        }
    }
}
