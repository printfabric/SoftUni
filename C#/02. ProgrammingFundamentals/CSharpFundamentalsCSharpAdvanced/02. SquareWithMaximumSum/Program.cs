using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new string[] { "," }
                , StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var sum = 0;
            var tempSum = 0;
            var indexFirst = 0;
            var indexSecond = 0;

            int[,] matrix = new int[input[0], input[1]];

            for (int row = 0; row < input[0]; row++)
            {
                var reedRow = Console.ReadLine()
                    .Split(new[] { "," }
                    , StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                for (int col = 0; col < input[1]; col++)
                {
                    matrix[row, col] = reedRow[col];
                }

            }

            for (int i = 0; i < input[0] - 1; i++)
            {
                for (int j = 0; j < input[1] - 1; j++)
                {
                    tempSum = matrix[i, j] + matrix[i, j + 1] 
                        + matrix[i + 1, j] + matrix[i + 1, j + 1];

                    if (tempSum > sum)
                    {
                        sum = tempSum;
                        indexFirst = i;
                        indexSecond = j;
                    }
                    tempSum = 0;
                }

            }

            Console.WriteLine(matrix[indexFirst, indexSecond] + " " + matrix[indexFirst, indexSecond + 1]);
            Console.WriteLine(matrix[indexFirst + 1, indexSecond] + " " + matrix[indexFirst + 1, indexSecond + 1]);
            Console.WriteLine(sum);
        }
    }
}

