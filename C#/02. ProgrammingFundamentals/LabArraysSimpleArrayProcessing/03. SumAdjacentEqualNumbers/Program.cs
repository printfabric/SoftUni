using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.RotateArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(new[] { ' ' },
                      StringSplitOptions.RemoveEmptyEntries).ToArray();            
            string[] newArray = new string[array.Length];
            var numberOfArray = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                newArray[numberOfArray] = array[i];
                numberOfArray++;
            }
            Console.Write(array[numberOfArray]);
            Console.Write(" {0}", string.Join(" ", newArray));
        }
    }
}
