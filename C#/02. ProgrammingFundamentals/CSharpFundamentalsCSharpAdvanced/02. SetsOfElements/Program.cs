using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var sets = Console.ReadLine()
                .Split(new[] {' '}
                , StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();

            for (int i = 0; i < sets[0]; i++)
            {
                var num = int.Parse(Console.ReadLine());
                firstSet.Add(num);
            }
            
            for (int i = 0; i < sets[1]; i++)
            {
                var num = int.Parse(Console.ReadLine());
                secondSet.Add(num);
            }

             firstSet.IntersectWith(secondSet);
             Console.WriteLine();
             foreach (var item in firstSet)
             {
                 Console.Write(item + " ");
             } 
        }
    }
}
