using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            var sum = 0;
            var anotherSum = 0;
            var counter = size - 1;

            for (int row = 0; row < size; row++)
            {
                var inputRow = Console.ReadLine()
                    .Split(new string[] { " " }
                    , StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = inputRow[col];
                    if(row == col)
                    {
                        sum += inputRow[col];
                    }
                    if(col == counter)
                    {
                        anotherSum += inputRow[col];
                        counter--;
                    }
                }
            }
            Console.WriteLine(Math.Abs(sum - anotherSum));
        }
    }
}
