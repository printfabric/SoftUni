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
            var listOne = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var listTwo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var listOneCount = new List<double>();
            var listTwoCount = new List<double>();

            for (int i = 0; i < listOne.Count; i++)
            {
                listOneCount.Add(Math.Floor(Math.Log10(Math.Abs(listOne[i])) + 1));
            }

            for (int i = 0; i < listTwo.Count; i++)
            {
                listTwoCount.Add(Math.Floor(Math.Log10(Math.Abs(listTwo[i])) + 1));
            }

            for (int i = 0; i < listOne.Count; i++)
            {
                if (Math.Floor(Math.Log10(Math.Abs(listOne[i])) + 1) > listOneCount.Min() 
                    || Math.Floor(Math.Log10(Math.Abs(listOne[i])) + 1) > listTwoCount.Min())
                {
                    listOne.RemoveAt(i);
                    i--;
                }
            }

            for (int i = 0; i < listTwo.Count; i++)
            {
                if (Math.Floor(Math.Log10(Math.Abs(listTwo[i])) + 1) > listTwoCount.Min() 
                    || Math.Floor(Math.Log10(Math.Abs(listTwo[i])) + 1) > listOneCount.Min())
                {
                    listTwo.RemoveAt(i);
                    i--;
                }
            }
            Console.WriteLine();

            //Console.WriteLine(string.Join(" ", listOne));
            //Console.WriteLine(string.Join(" ", listTwo));

            for (int i = 0; i < listOne.Count + listTwo.Count ; i++)
            {
                if (listTwo.Count > i)
                {
                    Console.Write(listTwo[i] + " ");
                }
                if (listOne.Count > i)
                {
                    Console.Write(listOne[i] + " ");
                }                 
            }
            
        }
    }
}
