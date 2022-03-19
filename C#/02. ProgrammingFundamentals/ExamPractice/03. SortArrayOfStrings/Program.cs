using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SortArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringList = Console.ReadLine().Split(new[] { ' ' }).ToList();

            stringList.Sort();

            Console.WriteLine(string.Join(" ", stringList));
        }
    }
}
