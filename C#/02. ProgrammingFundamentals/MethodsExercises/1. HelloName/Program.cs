using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            
            helloNmae();


        }

        private static void helloNmae()
        {
            var name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
