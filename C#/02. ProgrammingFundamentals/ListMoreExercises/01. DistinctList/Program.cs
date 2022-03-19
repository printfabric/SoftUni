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
            var newArray = Console.ReadLine().Split(new[] { ' ' }).
            Select(int.Parse).ToList();
            var repeatingNumbers = new List<int>();

            for (int i = 0; i < newArray.Count; i++)
            {
                for (int j = i+1; j < newArray.Count; j++)
                {
                    if(newArray[i] == newArray[j])
                    {
                        repeatingNumbers.Add(newArray[j]);
                        newArray.RemoveAt(j);
                    }
                }
            }

            for (int i = 0; i < newArray.Count; i++)
            {
                Console.Write(newArray[i] + " ");
            }

            //for (int i = 0; i < repeatingNumbers.Count; i++)
            //{
            //    Console.WriteLine(repeatingNumbers[i]);
            //}
        }
    }
}
