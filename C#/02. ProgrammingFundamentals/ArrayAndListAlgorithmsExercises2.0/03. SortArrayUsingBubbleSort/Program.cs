using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SortArrayUsingBubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var integerList = Console.ReadLine()
                .Split(new[] { ' ' })
                .Select(int.Parse)
                .ToList();
            var counter = 1;

            int temp = 0;

            for (int write = 0; write < integerList.Count; write++)
            {
                for (int sort = 0; sort < integerList.Count - 1; sort++)
                {
                    if (integerList[sort] > integerList[sort + 1])
                    {
                        temp = integerList[sort + 1];
                        integerList[sort + 1] = integerList[sort];
                        integerList[sort] = temp;
                    }
                }
            }


            for (int i = 0; i < integerList.Count; i++)
            {
                Console.Write(integerList[i] + " ");
            }

        }
    }
}

