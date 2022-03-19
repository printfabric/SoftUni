using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coddingExersice2
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var myQueue = new Queue<int>();
            var myList = new List<int>();
            myQueue.Enqueue(n);
            myList.Add(n);
            while(true)
            {
                var firstElement = myQueue.Dequeue();

                var firstNumber = firstElement + 1;
                var secondNumber = (firstElement * 2) + 1;
                var thirdNumber = firstElement + 2;

                myQueue.Enqueue(firstNumber);
                myQueue.Enqueue(secondNumber);
                myQueue.Enqueue(thirdNumber);

                myList.Add(firstNumber);
                myList.Add(secondNumber);
                myList.Add(thirdNumber);

            }

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(myList[i]);
            }
        }
    }
}
