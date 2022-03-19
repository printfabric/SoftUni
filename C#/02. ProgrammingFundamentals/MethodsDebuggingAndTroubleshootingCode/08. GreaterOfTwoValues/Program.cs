using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    {
                        var a = int.Parse(Console.ReadLine());
                        var b = int.Parse(Console.ReadLine());
                        Console.WriteLine(GetMax(a, b));
                        break;
                    }
                case "char":
                    {
                        var a = char.Parse(Console.ReadLine());
                        var b = char.Parse(Console.ReadLine());
                        Console.WriteLine(GetMax(a, b));
                        break;
                    }
                case "string":
                    {
                        var a = Console.ReadLine();
                        var b = Console.ReadLine();
                        Console.WriteLine(GetMax(a, b));
                        break;
                    }
            }
        }

        static int GetMax(int a, int b)
        {
            return Math.Max(a, b);
        }

        static char GetMax(char a, char b)
        {
            return (char)Math.Max(a, b);
        }

        static string GetMax(string str1, string str2)
        {
            if (str1.CompareTo(str2) >= 0)
            {
                return str1;
            }
            return str2;
        }
    }
}
