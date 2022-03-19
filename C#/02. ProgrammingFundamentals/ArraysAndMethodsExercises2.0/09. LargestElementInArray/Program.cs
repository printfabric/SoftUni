using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.LargestElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(GetLargestElementInArray(n));
        }

        static int GetLargestElementInArray(int n)
        {

            int[] newArray = new int[n + 1];

            for (int i = 1; i <= n; i++)
            {
                newArray[i] = int.Parse(Console.ReadLine());
                //Console.WriteLine(newArray[i]);
            }

            int maxValue = newArray.Max();
            return maxValue;
        }
    }
}
