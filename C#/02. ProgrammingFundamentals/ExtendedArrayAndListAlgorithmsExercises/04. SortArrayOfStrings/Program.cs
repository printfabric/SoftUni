using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SortArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrStrings = Console.ReadLine()
                .Split(new[] { ' ' })
                .ToArray();
            SortingArrayBubbleSort(arrStrings);
            Console.WriteLine(string.Join(" ", arrStrings));
        }

        static void SortingArrayBubbleSort(string[] arrStrings)
        {
            while (true)
            {
                bool swapped = false;
                for (int index = 0; index < arrStrings.Length - 1; index++)
                {
                    var c = arrStrings[index].CompareTo(arrStrings[index + 1]);
                    if (c > 0)
                    {
                        SwapTwoElements(ref arrStrings[index], ref arrStrings[index + 1]);
                        swapped = true;
                    }
                }

                //for (int i = 0; i < arrStrings.Length - 1; i++)
                //{
                //    if (arrStrings[i + 1].Any(char.IsUpper))
                //    {
                //        SwapTwoElements(ref arrStrings[i], ref arrStrings[i + 1]);
                //    }
                //}

                if (!swapped)
                {
                    break;
                }
            }
        }

        static void SwapTwoElements(ref string first, ref string second)
        {
            var temp = first;
            first = second;
            second = temp;
        }
    }
}
