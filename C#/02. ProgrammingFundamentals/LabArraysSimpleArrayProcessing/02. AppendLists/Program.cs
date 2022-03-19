using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine().Split(new[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            double[] newArray = new double[array.Length];

            double p = double.Parse(Console.ReadLine());
            var counter = 0.0;

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = p * array[i];
            }

            Console.WriteLine("{0}", string.Join(" ", newArray));
        }
    }
}
