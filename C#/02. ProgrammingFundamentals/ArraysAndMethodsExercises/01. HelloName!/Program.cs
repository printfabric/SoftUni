using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HelloName_
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
           Console.WriteLine($"Hello, {name}!");
        }
    }
}
