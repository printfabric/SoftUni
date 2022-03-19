using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CharRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringArray = Console.ReadLine();
            byte[] stringArrayToAsciiBytes = Encoding.ASCII.GetBytes(stringArray);
            int[] arrayOfNumbers = Console.ReadLine().Split(new[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();            

            for (int i = 0; i < stringArray.Length; i++)
            {
                if (arrayOfNumbers[i] % 2 == 0)

                {
                    var print = (stringArrayToAsciiBytes[i] - arrayOfNumbers[i]);
                    Console.Write((char)print);

                }
                else
                {
                    Console.Write((char)(stringArrayToAsciiBytes[i] + arrayOfNumbers[i]));
                }
            }

        }
    }
}
