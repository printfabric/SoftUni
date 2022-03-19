using System;
using System;

using System.Collections.Generic;

using System.Linq;
using System.Globalization;
using System.Text;

namespace _04.VariableInHexFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexadecimal = Console.ReadLine();            	
            Console.WriteLine(Convert.ToInt32(hexadecimal, 16));
            

        }
    }
}
