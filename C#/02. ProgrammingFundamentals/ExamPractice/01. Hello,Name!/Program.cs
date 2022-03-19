using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hello_Name_
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();

            PtintName(name);
        }

         static void PtintName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
