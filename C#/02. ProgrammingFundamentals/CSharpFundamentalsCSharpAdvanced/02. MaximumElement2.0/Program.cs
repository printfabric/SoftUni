﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MaximumElement2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();
            Stack<int> maxNumbers = new Stack<int>();
            int maxElement = int.MinValue;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] commandArgs = Console.ReadLine().Split();
                string command = commandArgs[0];

                if (command == "1")
                {
                    int numberToPush = int.Parse(commandArgs[1]);
                    myStack.Push(numberToPush);

                    if (numberToPush >= maxElement)
                    {
                        maxElement = numberToPush;
                        maxNumbers.Push(maxElement);
                    }

                    // Store max Element somewere
                }

                else if (command == "2")
                {
                    int elementAtTop = myStack.Pop();
                    int currentMaxNumber = maxNumbers.Peek();
                    if (elementAtTop == currentMaxNumber)
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
                else // 3
                {
                    Console.WriteLine(maxNumbers.Peek());
                }
            }
                       
        }
    }
}
