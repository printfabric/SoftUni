﻿using System;


namespace exercise
{
    class Program
    {

        static void Main(string[] args)
        {
            printReceipt();
            
        } 
        static void printReceipt()
        {
            printHeader();
            printBody();
            printFooter();
        }
        static void printHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
        static void printBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        static void printFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("© SoftUni");
        }
        
    }
}
