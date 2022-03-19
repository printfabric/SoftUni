using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new[] { ' ' })
            .Select(int.Parse).ToList();
            List<int> repetitiveNumers = new List<int>();
            numbers.Sort();
            var repeatNum = 1;
            var secondCounter = numbers.Count;

            for (int i = 0; i <= secondCounter + 1; i++)
            {
                for (int j = 1; j < secondCounter; j++)
                {
                    if (numbers[0] == numbers[j])
                    {
                        repeatNum++;
                        numbers.RemoveAt(0);
                        j--;
                        secondCounter--;
                    }
                }

                Console.WriteLine(numbers[0] + " -> " + repeatNum);
                numbers.RemoveAt(0);
                secondCounter = numbers.Count;
                repeatNum = 1;
            }
        }
    }
}
