using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StuckZipper
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstList = Console.ReadLine().
            Split(new[] { ' ' }).Select(int.Parse).ToList();
            var secondList = Console.ReadLine().
            Split(new[] { ' ' }).Select(int.Parse).ToList();

            var minNumInfirstList = 1000000;
            var digitCount = 1;
            var maxNumber = 1;     

            for (int i = 0; i < firstList.Count; i++)
            {
                if(Math.Abs(firstList[i]) < minNumInfirstList)
                {
                    minNumInfirstList = firstList[i];
                }
            }

            for (int i = 0; i < secondList.Count; i++)
            {
                if (Math.Abs(secondList[i]) < minNumInfirstList)
                {
                    minNumInfirstList = secondList[i];
                }
            }
                       
            for (int i = 1; i > 0; i++)
            {
                minNumInfirstList = Math.Abs(minNumInfirstList / 10);
                if (minNumInfirstList <= 0)
                {
                    break;
                }
                digitCount++;
            }

            for (int i = 0; i < digitCount; i++)
            {
                maxNumber = maxNumber * 10;
            }          

            for (int i = 0; i < firstList.Count; i++)
            {
                if(Math.Abs(firstList[i]) > (maxNumber -1))
                {
                    firstList.RemoveAt(i);
                    i--;                    
                }                    
            }

            for (int i = 0; i < secondList.Count; i++)
            {
                if (Math.Abs(secondList[i]) > (maxNumber - 1))
                {
                    secondList.RemoveAt(i);
                    i--;
                }
            }

            for (int i = 0; i < (firstList.Count + secondList.Count); i++)
            {
                if(i < secondList.Count)
                {

                    Console.Write(secondList[i] + " ");
                }
                if (i < firstList.Count)
                {
                    Console.Write(firstList[i] + " ");
                }
            }            
        }
    }
}
