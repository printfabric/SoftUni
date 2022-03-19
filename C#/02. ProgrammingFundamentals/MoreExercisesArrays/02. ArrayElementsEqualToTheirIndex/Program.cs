using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ArrayElementsEqualToTheirIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(new[] { ' ' },
                      StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
           // int[] newArray = new int[];

            for (int i = 0; i < array.Length; i++)
            {
                if (i == array[i])
                {
                    Console.Write(i + " ");
                }
            }

        }
    }
}
