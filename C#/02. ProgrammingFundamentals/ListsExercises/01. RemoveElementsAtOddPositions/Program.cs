using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RemoveElementsAtOddPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            var elements = Console.ReadLine()
                     .Split(new char[] { ' ' },
                     StringSplitOptions.RemoveEmptyEntries)
                     .ToList();

            var oddPositionElemnts = new List<string>();

            for (int i = 0; i < elements.Count; i++)
            {
                if (i % 2 != 0)
                {
                    oddPositionElemnts.Add(elements[i]);
                }
            }

            Console.WriteLine(string.Join("", oddPositionElemnts));
        }
    }
}