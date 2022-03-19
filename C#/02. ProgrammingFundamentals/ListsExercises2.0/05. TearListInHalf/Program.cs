using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.TearListInHalf
{
    class Program
    {
        static void Main(string[] args)
        {
            var newList = Console.ReadLine().
            Split(new[] { ' ' }).Select(int.Parse).ToList();
            var halfList = new List<int>();
            var counter = 0;
            var secondCounter = 0;           

            for (int i = (newList.Count / 2); i < newList.Count; i++)
            {
                halfList.Add(newList[i] / 10);
                halfList.Add(newList[i] % 10);
                Console.Write(halfList[counter] + " ");                
                Console.Write(newList[secondCounter] + " ");
                Console.Write(halfList[counter+1] + " ");
                secondCounter++;        
                counter+=2;
            }
        }
    }
}
