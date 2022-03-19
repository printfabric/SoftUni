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
            var n = int.Parse(Console.ReadLine());
            int[] newArray = new int[n];
            var count = 0;

            for (int i = 0; i < n; i++)
            {
                newArray[i] = Convert.ToInt32(Console.ReadLine());
                var currentArray = newArray[i];

                if (currentArray < 0)
                {
                    count+=1;
                }

            }
            Console.WriteLine(count);
        }
    }
}
