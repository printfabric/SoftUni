using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CountOfNegativeElementsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];
            var count = 0;

            for (int i = 0; i < N; i++)
            {
                var number = int.Parse(Console.ReadLine());
                arr[i] = number;
                if(arr[i] < 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
