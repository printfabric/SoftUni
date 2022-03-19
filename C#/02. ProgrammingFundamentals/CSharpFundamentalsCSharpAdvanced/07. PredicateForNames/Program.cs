using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var inputNames = Console.ReadLine().Split(' ').ToList();

            Func<int, List<string>, List<string>> upToFourLetterNames = NamesFilter;
            Console.WriteLine(string.Join("\n", upToFourLetterNames(n, inputNames)));
                
        }

        private static List<string> NamesFilter(int n, List<string> inputNames)
        {
            var filteredNames = new List<string>();
            for (int i = 0; i < inputNames.Count; i++)
            {
                if(inputNames[i].Length <= n)
                {
                    filteredNames.Add(inputNames[i]);
                }
            }
            return filteredNames;
        }
    }
}
