﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write("+");
            for (int i = 0; i < n - 2; i++)
                Console.Write(" -");
            Console.WriteLine(" +");

            for (int i = 0; i < n - 2; i++)
            {

                Console.Write("|");
                for (int row = 0; row < n - 2; row++)
                    Console.Write(" -");
                Console.WriteLine(" |");
            }

            Console.Write("+");
            for (int i = 0; i < n - 2; i++)
                Console.Write(" -");
            Console.WriteLine(" +");






        }
    }
}
