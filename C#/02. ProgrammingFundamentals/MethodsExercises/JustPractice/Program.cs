using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustPractice
{
    class Program
    {
        static void PrintHead(int size, char ch)
        {
            Console.Write("+");
            Console.Write(new string(ch, size-2));            
            Console.WriteLine("+");
        }

        static void Main(string[] args)
        {
            PrintHead(10, 'g');
            Console.WriteLine("Hello");
            PrintHead(10, 'g');
            SecondMain(1);
        }
        static void SecondMain(int size)
        {
            for (int i = 3; i < 20; i++)
            {
                PrintHead(i, '*');
            }

        }

    }
}
