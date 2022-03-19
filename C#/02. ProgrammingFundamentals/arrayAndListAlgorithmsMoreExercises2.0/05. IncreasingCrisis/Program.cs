using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.IncreasingCrisis
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var newList = new List<int>();
            var counter = 0;

            for (int i = 0; i < n; i++)
            {
                var sequencesOfIntegersList = Console.ReadLine()
                    .Split(new[] { ' ' })
                    .Select(int.Parse)
                    .ToList();

                for (int index = 0; index < sequencesOfIntegersList.Count-1; index++)
                {
                    if (sequencesOfIntegersList[index] > sequencesOfIntegersList[index + 1])
                    {
                        if(index == 0)
                        {
                            newList.Add(sequencesOfIntegersList[index]);
                            newList.Sort();
                        }
                        else
                        {
                            for (int p = 0; p < index +1; p++)
                            {
                                newList.Add(sequencesOfIntegersList[p]);
                                newList.Sort();
                            }
                        }
                        
                        for (int k = newList.Count-1; k > 0; k--)
                        {
                            if (newList[newList.Count-1] > sequencesOfIntegersList[index])
                            {
                                newList.RemoveAt(k);
                            }
                        }
                        counter++;
                    }
                }

                if(counter < 1)
                {
                    for (int j = 0; j < sequencesOfIntegersList.Count; j++)
                    {
                        newList.Add(sequencesOfIntegersList[j]);
                    }

                    newList.Sort();
                }
                counter = 0;
            }

            Console.Write(string.Join(" ", newList));
        }
    }
}

