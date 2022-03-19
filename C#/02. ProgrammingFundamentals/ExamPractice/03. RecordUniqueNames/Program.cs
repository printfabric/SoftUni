using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RecordUniqueNames
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            var newHashSet = new HashSet<string>();

            for (int i = 0; i < num; i++)
            {
                var name = Console.ReadLine();
                newHashSet.Add(name);
            }

            Console.WriteLine(string.Join("\n", newHashSet));
        }
    }
}
