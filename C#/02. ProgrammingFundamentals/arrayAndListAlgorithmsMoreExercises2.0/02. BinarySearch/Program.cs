using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfIntLinear = Console.ReadLine()
                .Split(new[] { ' ' })
                .Select(int.Parse)
                .ToList();
            var listOfIntBinary = new List<int>();

            for (int i = 0; i < listOfIntLinear.Count; i++)
            {
                listOfIntBinary.Add(listOfIntLinear[i]);
            }

            listOfIntBinary.Sort();

            var searchedElement = int.Parse(Console.ReadLine());
            var counter = 0;
            var secondCounter = 0;

            for (int i = 0; i < listOfIntLinear.Count; i++)
            {
                secondCounter++;

                if (listOfIntLinear[i] == searchedElement)
                {
                    break;
                }
                counter++;
            }

            if (counter == listOfIntLinear.Count)
            {
                Console.WriteLine("No");
                Console.WriteLine("Linear search made " + (counter) + " iterations");

            }
            else
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Linear search made "+ (secondCounter) +" iterations");
            }

            var x = false;
            var upperBound = listOfIntBinary.Count;
            var lowerBound = 0;
            var midPoint = lowerBound + (upperBound - lowerBound) / 2;
            counter = 0;

            while (true)
            {
                counter++;
                if (upperBound < lowerBound)
                {
                    Console.WriteLine($"Binary search made {counter} iterations");
                    return;
                }                               

                if (listOfIntBinary[midPoint] < searchedElement)
                {
                    lowerBound = midPoint + 1;
                    midPoint = lowerBound + (upperBound - lowerBound) / 2;
                }
                if (listOfIntBinary[midPoint] > searchedElement)
                {
                    upperBound = midPoint - 1;
                    midPoint = lowerBound + (upperBound - lowerBound) / 2;
                }

                if (listOfIntBinary[midPoint] == searchedElement)
                {
                    Console.WriteLine($"Binary search made {counter} iterations");
                    break;
                }
            }
        }
    }
}
