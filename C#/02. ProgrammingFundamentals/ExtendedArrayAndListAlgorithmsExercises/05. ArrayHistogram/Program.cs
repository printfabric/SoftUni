using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ArrayHistogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringList = Console.ReadLine()
                .Split(new[] { ' ' })
                .ToList();
            var counter = 0;
            var occursList = new List<double>();
            var statisticaList = new List<double>();
            var sumOfoccursList = 0;

            //Array.Sort(stringArray, (x1, x2) => x1.Length.CompareTo(x2.Length));
            //Array.Sort(stringArray);
            stringList.Sort();

            for (int i = 0; i < stringList.Count; i++)
            {
                for (int j = 1; j < stringList.Count - i; j++)
                {
                    var compare = stringList[i]
                    .CompareTo(stringList[j + i]);
                    if (compare == 0)
                    {
                        stringList.RemoveAt(j + i);
                        j--;
                        counter++;
                    }
                }

                occursList.Add(counter + 1);
                sumOfoccursList = sumOfoccursList + (counter + 1);
                counter = 0;
            }

            for (int i = 0; i < occursList.Count; i++)
            {
                var po = (occursList[i] / sumOfoccursList) * 100;
                statisticaList.Add(Math.Round(po, 2));
            }

            while (true)
            {
                bool swapped = false;
                for (int index = 0; index < occursList.Count - 1; index++)
                {
                    if (occursList[index] < occursList[index + 1])
                    {
                        if (occursList[index] < occursList[index + 1])
                        {
                            occursList.Insert(index, occursList[index + 1]);
                            stringList.Insert(index, stringList[index + 1]);
                            statisticaList.Insert(index, statisticaList[index + 1]);
                            occursList.RemoveAt(index + 2);
                            stringList.RemoveAt(index + 2);
                            statisticaList.RemoveAt(index + 2);
                            swapped = true;
                        }
                    }
                }

                if (!swapped)
                {
                    break;
                }
            }
           
            for (int i = 0; i < stringList.Count; i++)
            {
                Console.WriteLine
                ($"{stringList[i]} -> {occursList[i]} times ({statisticaList[i]}%)");
            }

        }     
    }
}

