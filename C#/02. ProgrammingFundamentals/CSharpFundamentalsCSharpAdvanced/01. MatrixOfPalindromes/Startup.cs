using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MatrixOfPalindromes
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new string[] { " " }
                , StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            var rows = input[0];
            var cols = input[1];

            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            char[][] palindromes = new char[rows][];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    palindromes[row] = new char[3];
                    palindromes[row][0] = alphabet[row];
                    palindromes[row][1] = alphabet[col + row];
                    palindromes[row][2] = alphabet[row];

                    foreach (var item in palindromes[row])
                    {
                        Console.Write(item);
                    }
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
