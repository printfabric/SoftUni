using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercises2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintName();

        }

         static void PrintName()
        {
            var name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);
            
        }
    }
}
