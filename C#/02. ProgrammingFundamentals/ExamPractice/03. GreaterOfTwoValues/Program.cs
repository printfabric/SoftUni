using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
                      

            if(type == "int")
            {
                var firstInput = int.Parse(Console.ReadLine());
                var secondInput = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(firstInput, secondInput));
            }
            else if (type == "char")
            {
                char firstInput = char.Parse(Console.ReadLine());
                char secondInput = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(firstInput, secondInput));
            }
            else if (type == "string")
            {
                var firstInput = Console.ReadLine();
                var secondInput = Console.ReadLine();
                Console.WriteLine(GetMax(firstInput, secondInput));
            }

        }

        static int GetMax(int firsInput, int secondInput)
        {
            if (firsInput > secondInput)
            {
                return firsInput;

            }
            else
            {
                return secondInput;
            }

        }
        static char GetMax(char firsInput, char secondInput)
        {
            if (firsInput > secondInput)
            {
                return firsInput;

            }
            else
            {
                return secondInput;
            }

        }
        static string GetMax(string firsInput, string secondInput)
        {
            if (firsInput.CompareTo(secondInput) >= 0)
            {
                return firsInput;
            }
            else
            {
                return secondInput;
            }

        }
    }
}
