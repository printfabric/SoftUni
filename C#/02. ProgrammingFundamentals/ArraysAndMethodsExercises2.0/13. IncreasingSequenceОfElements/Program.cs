using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.IncreasingSequenceОfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] newArray = Console.ReadLine().Split(new[] { ' ' },
               StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var counter = 0;


            for (int i = 0; i < newArray.Length - 1; i++)
            {
                if (newArray[i + 1] < newArray[i])
                {
                    counter += 1;
                    Console.WriteLine("No");
                    break;
                }

            }
            if (counter == 0)
            {
                Console.WriteLine("Yes");
            }

        }
    }
}
