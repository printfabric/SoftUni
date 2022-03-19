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
            var listOne = Console.ReadLine()
                .Split(new[] { " " }
                , StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var listTwo = Console.ReadLine()
                 .Split(new[] { " " }
                 , StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();

            for (int i = 0; i < listOne.Count; i++)
            {
                for (int j = 0; j < listTwo.Count; j++)
                {
                    if(listOne[i] == listTwo[j])
                    {
                        listTwo.RemoveAt(j);
                    }
                }
            }

            if (listOne.Sum() == listTwo.Sum())
            {
                Console.WriteLine("Yes. Sum: {0}", listTwo.Sum());
            }
            else
            {
                Console.WriteLine("No. Diff: {0}", Math.Abs(listOne.Sum() - listTwo.Sum()));
            }
        }
    }
}
