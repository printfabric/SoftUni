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
            var numberList = Console.ReadLine().
            Split(new[] { ' ' }).Select(int.Parse).ToList();
            List<int> reversedList = new List<int>();

            // reversedList.Add(numberList[0]);
            var counter = numberList.Count - 2;

            if (numberList.Count % 2 != 0)
            {
                for (int i = 1; i <= (numberList.Count / 2); i++)
                {
                    reversedList.Add(numberList[counter]);

                    counter--;
                }
            }

            else
            {
                for (int i = 1; i < (numberList.Count / 2); i++)
                {
                    reversedList.Add(numberList[counter]);

                    counter--;
                }
            }


            for (int i = 1; i < (numberList.Count / 2); i++)
            {
                reversedList.Add(numberList[counter]);
                counter--;

            }

            Console.Write(numberList[0] + " ");
            for (int i = 0; i < reversedList.Count; i++)
            {
                Console.Write(reversedList[i] + " ");
            }
            Console.WriteLine(numberList[numberList.Count - 1]);
        }
    }
}
