using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rubik_s_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { " " }
                , StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var r = input[0];
            var c = input[1];
            int[,] matrix = new int[r, c];
            var counter = 1;

            for (int row = 0; row < r; row++)
            {
                for (int col = 0; col < c; col++)
                {
                    matrix[row, col] = counter;
                    counter++;
                }
            }

            for (int i = 0; i < r; i++)
            {
                var command = 1;
                for (int j = 0; j < c; j++)
                {
                    if(command == j)
                    {
                        matrix[i, j] = matrix[i, j + 1]
                    }
                }
            }
        }
    }
}
