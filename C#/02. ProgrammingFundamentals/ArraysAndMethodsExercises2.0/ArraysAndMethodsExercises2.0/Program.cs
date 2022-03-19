using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndMethodsExercises2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();

            PrintingHelloName(name);
        }

        static void PrintingHelloName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
