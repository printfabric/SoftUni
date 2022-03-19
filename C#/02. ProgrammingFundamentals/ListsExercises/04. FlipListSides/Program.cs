using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FlipListSides
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                    .Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

            //take first and last number
            var firstNumber = numbers[0];
            var secondNumber = numbers[numbers.Count - 1];

            //remove first and last number
            numbers.RemoveAt(numbers.Count - 1);
            numbers.RemoveAt(0);

            //reverse the list
            numbers.Reverse();

            // returnt back the first and last number
            numbers.Add(secondNumber);
            numbers.Insert(0, firstNumber);

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
