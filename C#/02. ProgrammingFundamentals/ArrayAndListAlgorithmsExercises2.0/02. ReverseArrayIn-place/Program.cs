using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReverseArrayIn_place
{
    class Program
    {
        static void Main(string[] args)
        {
            var integersArr = Console.ReadLine()
                .Split(new[] { ' ' })
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < integersArr.Length / 2; i++)
            {
                var leftSide = i;
                var rightSide = integersArr.Length - 1 - i;

                var temp = integersArr[leftSide];
                integersArr[leftSide] = integersArr[rightSide];
                integersArr[rightSide] = temp; 
            }

            for (int i = 0; i < integersArr.Length; i++)
            {
                Console.Write(integersArr[i] + " ");
            }
        }
    }
}
