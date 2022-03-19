using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50.Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var surName = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Hello, {name} {surName}.\r\nYou are {age} years old.");
        }
    }
}
