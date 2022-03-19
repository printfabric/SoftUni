using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EqualSumAfterExtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstList = Console.ReadLine().Split(new[] { ' ' }).
                Select(int.Parse).ToList();
            var secondList = Console.ReadLine().Split(new[] { ' ' }).
                Select(int.Parse).ToList();
            var sumOfFirstList = 0;
            var sumOfSecondList = 0;

            for (int i = 0; i < firstList.Count; i++)
            {
                for (int j = 0; j < secondList.Count; j++)
                {
                    if(firstList[i] == secondList[j])
                    {
                        secondList.RemoveAt(j);
                        j--;
                    }
                }
            }

            for (int i = 0; i < firstList.Count; i++)
            {
                sumOfFirstList = sumOfFirstList + firstList[i];
            }

            for (int i = 0; i < secondList.Count; i++)
            {
                sumOfSecondList = sumOfSecondList + secondList[i];
            }

            if(sumOfFirstList == sumOfSecondList)
            {
                Console.WriteLine("Yes.Sum: {0}", sumOfFirstList);
            }
            else
            {
                Console.WriteLine("No. Diff: {0}", Math.Abs(sumOfSecondList - sumOfFirstList));
            }
        }
    }
}
