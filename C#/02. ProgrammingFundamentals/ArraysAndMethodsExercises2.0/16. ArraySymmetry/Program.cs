using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.ArraySymmetry
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] newArray = Console.ReadLine().Split(new[] { ' ' },
                      StringSplitOptions.RemoveEmptyEntries).ToArray();            
            var counterNo = 0;
            var counter = 1;          

            for (int i = 0; i < newArray.Length / 2; i++)
            {
                if (newArray[i] != newArray[newArray.Length - counter])
                {
                    counterNo++;
                }
                counter++;
            }

            if (counterNo > 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
        }
    }
}
