using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.InsertionSortUsingList
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new[] { ' ' })
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                bool swapped = false;
                for (int index = 0; index < numbers.Count - 1; index++)
                {
                    if (numbers[index] > numbers[index + 1])
                    {
                        numbers.Insert(index, numbers[index + 1]);
                        numbers.RemoveAt(index + 2);                 
                        swapped = true;
                    }
                }
                if (!swapped)
                {
                    break;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

