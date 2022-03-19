using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CharRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();

            char[] letters = str.ToCharArray();

            var intArr = Console.ReadLine()
                .Split(new[] { ' ' }
                , StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] newArr = new int[letters.Length];

            for (int i = 0; i < intArr.Length; i++)
            {
                if (intArr[i] % 2 == 0)
                {
                    newArr[i] = letters[i] - intArr[i];
                }
                else
                {
                    newArr[i] = letters[i] + intArr[i];
                }
            }

            for (int i = 0; i < newArr.Length; i++)
            {
                Console.Write((char)newArr[i]);
            }
        }
    }
}
