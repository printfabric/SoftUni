using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._5DifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            if (b - a >= 5)
            {
                for (int i = a; i <= b; i++)
                {
                                        
                    for (int j = i + 1; j <= b; j++)
                    {
                        
                        for (int x = j + 1; x <= b; x++)
                        {
                            
                            for (int y = x + 1; y <= b; y++)
                            {
                                
                                for (int z = y + 1; z <= b; z++)
                                {
                                    Console.Write(i + " ");
                                    Console.Write(j + " ");
                                    Console.Write(x + " ");
                                    Console.Write(y + " ");
                                    Console.Write(z);

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
