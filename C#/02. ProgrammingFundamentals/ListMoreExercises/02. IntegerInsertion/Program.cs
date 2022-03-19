using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IntegerInsertion
{
    class Program
    {
        static void Main(string[] args)
        {
            var newList = Console.ReadLine().Split(new[] { ' ' }).
            Select(int.Parse).ToList();
            var secondList = new List<int>();
            var listLimit = 100;
            var empty = 0;

            for (int i = 0; i < listLimit; i++)
            {
                var num = Console.ReadLine();
                empty = 0;
                if (num == "end")
                {
                    break;
                }                
                else
                {
                    int.TryParse(num, out empty);                  
                    int firstDigit = (int)(empty/ Math.Pow(10, (int)Math.Floor(Math.Log10(empty))));
                    newList.Insert(firstDigit, empty);                   
                }
            }
           
            for (int i = 0; i < newList.Count; i++)
            {
                Console.Write(newList[i] + " ");
            }
        }
    }
}
