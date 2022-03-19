using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var countOfNames = int.Parse(Console.ReadLine());

            var setOfNames = new HashSet<string>();

            for (int i = 0; i < countOfNames; i++)
            {
                var name = Console.ReadLine();

                setOfNames.Add(name);
            }

            foreach (var name in setOfNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
