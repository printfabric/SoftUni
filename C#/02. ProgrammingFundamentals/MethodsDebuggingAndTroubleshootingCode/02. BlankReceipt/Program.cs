using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BlankReceipt
{
    class Program
    {
        static void Main(string[] args)
        {            
            PrintReceipt();
        }

        static void PrintReceipt()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }

        static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
           // Console.WriteLine();
        }
        
        static void PrintBody()
        {
            Console.WriteLine("Chaeged to____________________ ");
            Console.WriteLine("Received by___________________");
            //Console.WriteLine();
        }

        static void PrintFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("© " + "SoftUni");
        }

    }
}
