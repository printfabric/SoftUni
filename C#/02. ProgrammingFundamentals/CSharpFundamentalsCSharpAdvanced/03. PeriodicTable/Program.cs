using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var chemicalCompoundSet = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                var chemicalCompound = Console.ReadLine().Split(' ').ToList();

                for (int j = 0; j < chemicalCompound.Count; j++)
                {
                    chemicalCompoundSet.Add(chemicalCompound[j]);
                }
            }
            Console.WriteLine();
            foreach (var compound in chemicalCompoundSet)
            {
                Console.Write(compound + " ");
            }
        }
    }
}
