using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BasicStackOperations2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var n = int.Parse(input[0]); 
            var s = int.Parse(input[1]); 
            var x = int.Parse(input[2]);
            var elements = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            var newStack = new Stack<int>();
            var counter = 0;

            for (int i = 0; i < n; i++)
            {
                newStack.Push(elements[i]);
            }

            for (int i = 0; i < s; i++)
            {
                newStack.Pop();
            }

            foreach (var item in newStack)
            {
                
                if(item == x)
                {
                    Console.WriteLine("true");
                    counter++;
                    break;
                }
            }

            if (newStack.Count == 0)
            {
                Console.WriteLine("0");
                counter++;
                
            }

            else if (counter == 0)
            {
                Console.WriteLine(newStack.Min());
            }
        }
    }
}
