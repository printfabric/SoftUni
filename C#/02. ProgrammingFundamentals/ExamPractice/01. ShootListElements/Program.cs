using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ShootListElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var counter = 1;
            var lastOne = 0;
            var list = new List<int>();

            while(input != "stop")
            {
                int temp;
                if (int.TryParse(input, out temp))
                {
                    list.Add(temp);
                }
                else
                {
                    var average = 0;

                    if(list.Count > 0)
                    {
                         average = list.Sum() / list.Count;
                    }

                    if (counter > 0)
                    {
                        list.Reverse();
                        counter--;
                    }

                    for (int i = 0; i < list.Count; i++)
                    {
                        if(list[i] <= average)
                        {
                            if (list.Count < 1)
                            {
                                Console.WriteLine($"shot {list[i]}");
                                Console.WriteLine($"nobody left to shoot! last one was {list[i]}");
                                goto End;
                            }
                            Console.WriteLine($"shot {list[i]}");
                            lastOne = list[i];
                            list.RemoveAt(i);


                            for (int j = 0; j < list.Count; j++)
                            {
                                list[j] = list[j] - 1;
                            }
                            break;
                        }
                    }
                }

                input = Console.ReadLine();

                if(list.Count <= 0 && input == "stop")
                {
                    goto next;
                }
                else if(list.Count == 0 && input != "stop")
                {
                    Console.WriteLine($"nobody left to shoot! last one was {lastOne}");
                    goto End;
                }
            }

            next:;
            if(list.Count > 0)
            {
                Console.WriteLine("survivors: " + string.Join(" ", list));
            }
            else
            {
                Console.WriteLine($"you shot them all. last one was {lastOne}");
            }

            End:;
        }
    }
}
