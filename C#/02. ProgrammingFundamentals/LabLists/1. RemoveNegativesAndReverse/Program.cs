using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var newList = Console.ReadLine().Split(new[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var num = new List<int>();
            var counter = 0;

            for (int i = newList.Length-1; i >= 0; i--)
            {
                if (newList[i] >= 0)
                {
                    num.Add((newList[i]));
                    Console.Write(num[counter] + " ");
                    counter++;
                }                
            }
            if(counter == 0)
            {
                Console.WriteLine("empty");
            }
        }
    }
}
