using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numList = Console.ReadLine().Split(new[] { ' ' })
            .Select(int.Parse).ToList();
            var cicle = numList.Count;
                        
            for (int i = 0; i < cicle; i++)
            {
                if(i > 0)
                {
                    if (numList[i] == numList[i - 1])
                    {
                        var sum = numList[i] + numList[i-1];
                        numList.RemoveAt(i);
                        numList.RemoveAt(i-1);
                        numList.Insert(i-1, sum);

                        i = 0;
                        cicle = numList.Count;
                    }                    
                }                
            }
            Console.WriteLine(string.Join(" ", numList));
        }
    }
}
