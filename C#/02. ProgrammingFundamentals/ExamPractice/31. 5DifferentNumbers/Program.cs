using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31._5DifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            if((b - a) >= 5)
            {
                for (int i = a; i <= b; i++)
                {
                    for (int j = i + 1; j <= b; j++)
                    {
                        for (int k = j + 1; k <= b; k++)
                        {
                            for (int l = k + 1; l <= b; l++)
                            {
                                for (int o = l + 1; o <= b; o++)
                                {
                                    Console.Write(i + " ");
                                    Console.Write(j + " ");
                                    Console.Write(k + " ");
                                    Console.Write(l + " ");
                                    Console.Write(o + " ");
                                    Console.WriteLine();

                                }
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
