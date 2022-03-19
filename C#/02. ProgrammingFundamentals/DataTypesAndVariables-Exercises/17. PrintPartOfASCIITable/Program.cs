using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _17.PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            var begin = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());

            //Console.OutputEncoding = Encoding.Unicode;
            //Console.BufferHeight = 256;

           
            for (int i = begin; i <= end; i++)
            {
                char c = (char)i;
                Console.Write((char)i + " ");
                

            }


        }
    }
}
