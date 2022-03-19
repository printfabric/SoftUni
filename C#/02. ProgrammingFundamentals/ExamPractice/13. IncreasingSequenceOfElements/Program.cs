using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.IncreasingSequenceOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split(new[] { " " }
                , StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < arr.Length -1; i++)
            {
                if(arr[i] >= arr[i+1])
                {
                    Console.WriteLine("No");
                    goto End;
                }
            }

            Console.WriteLine("Yes");
            End:;
        }
    }
}
