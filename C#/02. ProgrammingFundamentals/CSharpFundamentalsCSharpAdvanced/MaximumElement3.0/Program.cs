using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumElement3._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var originalStack = new Stack<int>();
            var maxNumbers = new Stack<int>();
            var maxElement = int.MinValue;
            

            for (int i = 0; i < n; i++)
            {
                string[] queri = Console.ReadLine().Split();
                var command = queri[0];

                if(command == "1")
                {
                    var currentElement = int.Parse(queri[1]);
                    originalStack.Push(currentElement);
                    if(currentElement > maxElement)
                    {
                        maxElement = currentElement;
                        maxNumbers.Push(maxElement);
                    }

                }

                else if (command == "2")
                {
                    var deleteElementOnTop = originalStack.Pop();
                    var peek = maxNumbers.Peek();

                    if(deleteElementOnTop == peek)
                    {
                        maxNumbers.Pop();
                        if (maxNumbers.Count > 0)
                        {
                            maxElement = maxNumbers.Peek();
                        }
                        else
                        {
                            maxElement = int.MinValue;
                        }
                    }
                }

                else // command == "3"
                {
                    Console.WriteLine(maxNumbers.Peek());
                }
            }
        }
    }
}
