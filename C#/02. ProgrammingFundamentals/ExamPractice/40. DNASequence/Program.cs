
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.TrainingHallEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    for (int x = 1; x <= 4; x++)
                    {

                        int[] number = new int[5];
                        number[1] = 'A';
                        number[2] = 'C';
                        number[3] = 'G';
                        number[4] = 'T';

                        if (i + j + x >= n)
                        {
                            Console.Write("O");
                        }
                        else
                        {
                            Console.Write("X");
                        }

                        string a = Encoding.ASCII.GetString(new byte[] { (byte)number[i] });
                        string b = Encoding.ASCII.GetString(new byte[] { (byte)number[j] });
                        string c = Encoding.ASCII.GetString(new byte[] { (byte)number[x] });

                        Console.Write(a);
                        Console.Write(b);
                        Console.Write(c);

                        if (i + j + x >= n)
                        {
                            Console.Write("O");
                        }
                        else
                        {
                            Console.Write("X");
                        }

                        Console.Write(" ");
                    }
                    Console.WriteLine();

                }
            }
        }
    }
}

