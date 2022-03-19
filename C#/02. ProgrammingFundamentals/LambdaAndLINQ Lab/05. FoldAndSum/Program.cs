using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var newList = Console.ReadLine()
                .Split(new[] { ' ' })
                .Select(int.Parse)
                .ToList();            

            var firstNumbers = newList
                .Take(newList.Count / 4)                
                .ToList();
            firstNumbers.Reverse();

            var reversedList = new List<int>(newList);
            reversedList.Reverse();

            var lastNumbers = reversedList.Take(newList.Count / 4).ToList();

            var allNumbers = firstNumbers.Concat(lastNumbers).ToList();
            var counter = 0;
             
            var collectedNumbers = new List<int>();

            for (int i = newList.Count / 4; i < newList.Count - newList.Count / 4; i++)
            {
                collectedNumbers.Add(allNumbers[counter] + newList[i]);
                counter++;
            }
            Console.WriteLine(string.Join(" ", collectedNumbers));
            //Console.WriteLine(string.Join(" ", allNumbers));
            //Console.WriteLine(string.Join(" ", firstNumbers));
            //Console.WriteLine(string.Join(" ", lastNumbers));
        }
    }
}
