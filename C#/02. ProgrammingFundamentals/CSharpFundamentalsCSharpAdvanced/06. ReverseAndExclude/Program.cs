using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var devider = int.Parse(Console.ReadLine());

            Func<List<int>, int, string> reversNumbers = Revers;
            Console.WriteLine(reversNumbers(inputNumbers, devider));
        }

        public static string Revers(List<int> inputNumbers, int devider)
        {
            var reversedNumbers = new List<int>();
            for (int i = inputNumbers.Count; i > 0; i--)
            {
                if (inputNumbers[i-1] % devider != 0)
                {
                    reversedNumbers.Add(inputNumbers[i-1]);
                }
            }
            var rev = string.Join(" ", reversedNumbers);
            return rev;
        }
    }
}
