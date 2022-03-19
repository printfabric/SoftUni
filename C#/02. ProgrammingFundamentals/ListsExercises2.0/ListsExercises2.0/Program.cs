using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsExercises2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var newList = Console.ReadLine().Split(new[] {' '},
                StringSplitOptions.RemoveEmptyEntries).ToList();
            // var reducedList = new List<string>();

            for (int i = 0; i < newList.Count; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(newList[i]);
                }

            }

        }
    }
}
