using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.UnunionLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var primalList = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var N = int.Parse(Console.ReadLine());

            //for (int i = 0; i < N; i++)
            //{
            //var seqOfInt = Console.ReadLine().Split(new[] { ' ' }
            //,StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            for (int j = 0; j < N; j++)
            {
                var seqOfInt = Console.ReadLine().Split(new[] { ' ' }
            , StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

                for (int k = 0; k < seqOfInt.Count; k++)
                {
                    if (primalList.Contains(seqOfInt[k]))
                    {
                    }
                    else
                    {
                        primalList.Add(seqOfInt[k]);
                        seqOfInt.RemoveAt(k);
                        k--;
                    }
                }

                for (int k = 0; k < primalList.Count; k++)
                {
                    for (int h = 0; h < seqOfInt.Count; h++)
                    {
                        if (seqOfInt[h] == primalList[k])
                        {
                            primalList.RemoveAt(k);
                            k--;
                        }
                    }

                    //else if (seqOfInt[i])
                }

            }
            // }
            primalList.Sort();
            Console.WriteLine(string.Join(" ", primalList));

        }
    }
}
