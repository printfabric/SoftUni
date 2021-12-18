using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ges_The_Pass
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputParam = (Console.ReadLine());

            if (inputParam == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
