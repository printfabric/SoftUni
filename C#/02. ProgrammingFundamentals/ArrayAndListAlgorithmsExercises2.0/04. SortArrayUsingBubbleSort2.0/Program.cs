using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.indexarrayUsingBubbleindex2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split(new[] { ' ' })
                .Select(int.Parse)
                .ToArray();
            SortingArrayBubbleSort(arr);
            Console.WriteLine(string.Join(" ", arr));          
        }

        static void SortingArrayBubbleSort(int[] arr)
        {
            while (true)
            {
                bool swapped = false;
                for (int index = 0; index < arr.Length - 1; index++)
                {
                    if (arr[index] > arr[index + 1])
                    {
                        SwapTwoElements(ref arr[index], ref arr[index + 1]);
                        swapped = true;
                    }
                }
                if (!swapped)
                {
                    break;
                }
            }
        }

        static void SwapTwoElements(ref int first, ref int second)
        {
            var temp = first;
            first = second;
            second = temp;
        }
    }
}
