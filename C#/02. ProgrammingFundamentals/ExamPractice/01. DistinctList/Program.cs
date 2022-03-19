using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DistinctList
{
    class Program
    {
        static void Main(string[] args)
        {
            var intList = Console.ReadLine()
                .Split(new[] {' '})
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < intList.Count; i++)
            {
                for (int j = i+1; j < intList.Count; j++)
                {
                    if (intList[i] == intList[j])
                    {
                        intList.RemoveAt(j);
                        j--;
                    }
                }
                
            }

            Console.WriteLine(string.Join(" ", intList));
        }
    }
}
