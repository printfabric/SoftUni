using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SumMatrixElements
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            var countOfRows = input[0];
            var countOfColumns = input[1];
            var sum = 0;
            int[,] matrix = new int[countOfRows, countOfColumns];
            
            
            for (int i = 0; i < countOfRows; i++)
            {
                var inputRaw = Console.ReadLine().Split(new[] { "," }
                    , StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                for (int j = 0; j < countOfColumns; j++)
                {
                    matrix[i, j] = inputRaw[j];
                }
            }

            for (int i = 0; i < countOfRows; i++)
            {
                for (int j = 0; j < countOfColumns; j++)
                {
                    sum += matrix[i, j];
                }
            }

            Console.WriteLine(countOfRows);
            Console.WriteLine(countOfColumns);
            Console.WriteLine(sum);

        }
    }
}
