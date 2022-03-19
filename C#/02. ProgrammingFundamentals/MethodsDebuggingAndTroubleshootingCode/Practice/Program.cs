using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static string a = "hui";
        static void PrintHead(int size, char ch)
        {
            Console.WriteLine(a);
            Console.Write("+");
            PrintMainHeaderPart(size, ch);
            Console.WriteLine("+");
        }

        static void PrintMainHeaderPart(int size, char ch)
        {
            Console.Write(new string(ch, size - 2));
        }

        static void Main()
        {
            PrintHead(70 , 'g');
            Console.WriteLine("hello");
            PrintHead(6, 't');
            Console.WriteLine(a);

        }
    }
}
