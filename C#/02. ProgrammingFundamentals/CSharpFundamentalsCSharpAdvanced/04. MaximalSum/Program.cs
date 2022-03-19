using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = Console.ReadLine()
                .Split(new string[] { " " }
                , StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var rows = size[0];
            var cols = size[1];
            int[,] matrix = new int[rows, cols];
            var sum = 0;
            var maxSum = 0;
            var counter = 0;
            int[] index = new int[2];
            var r = 0;
            var c = 0;

            for (int row = 0; row < rows; row++)
            {
                var currentRow = Console.ReadLine()
                    .Split(new string[] { " " }
                    , StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }

            }

            for (int a = 0; a < rows - 2; a++)
            {

                for (int i = 0; i < cols - 2; i++)
                {
                    for (int j = a; j < 3 + a; j++)
                    {
                        for (int k = counter; k < 3 + counter; k++)
                        {
                            sum += matrix[j, k];
                            r = j;
                            c = k;
                        }
                    }
                    if(sum > maxSum)
                    {
                        maxSum = sum;
                        index[0] = r;
                        index[1] = c;
                    }
                    sum = 0;
                    counter++;
                }
                counter = 0;
            }
            Console.WriteLine("Sum = " + maxSum);
            for (int row = index[0] - 2; row < index[0] + 1; row++)
            {
                for (int i = index[1] - 2; i < index[1] + 1; i++)
                {
                    Console.Write(matrix[row, i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

