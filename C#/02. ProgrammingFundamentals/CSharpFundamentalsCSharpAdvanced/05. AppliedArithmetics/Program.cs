using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var command = Console.ReadLine();
            Func<int, int> add = x => x + 1;
            Func<int, int> multiply = x => x * 2;
            Func<int, int> subtract = x => x - 1;

            while (command != "end")
            {
                if(command == "add")
                {
                    inputNumbers = inputNumbers.Select(add).ToList();
                }
                else if (command == "multiply")
                {
                    inputNumbers = inputNumbers.Select(multiply).ToList();
                }
                else if (command == "subtract")
                {
                    inputNumbers = inputNumbers.Select(subtract).ToList();
                }
                else if (command == "print")
                {
                    Console.WriteLine(string.Join(" ", inputNumbers));
                }
                command = Console.ReadLine();
            }
        }
    }
}
