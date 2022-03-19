using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "True":
                    Console.WriteLine("Yes");
                    break;
                case "False":
                    Console.WriteLine("No");
                    break;
                default: Console.WriteLine("error");
                    break;
            }

        }
    }
}
