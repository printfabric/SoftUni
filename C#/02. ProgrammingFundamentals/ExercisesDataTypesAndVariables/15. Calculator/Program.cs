using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {



            var firstNumber = int.Parse(Console.ReadLine());
            string operatorNumber = Console.ReadLine();
            var secondNumber = int.Parse(Console.ReadLine());
            

            if (operatorNumber == "+")
            {
                Console.WriteLine($"{firstNumber} {operatorNumber} {secondNumber}" + " = " + (firstNumber + secondNumber));
            } 
            else if (operatorNumber == "-")
            {
                Console.WriteLine($"{firstNumber} {operatorNumber} {secondNumber}" + " = " + (firstNumber - secondNumber));

            }
            else if (operatorNumber == "*")
            {
                Console.WriteLine($"{firstNumber} {operatorNumber} {secondNumber}" + " = " + (firstNumber * secondNumber));

            }
            else if (operatorNumber == "/")
            {
                Console.WriteLine($"{firstNumber} {operatorNumber} {secondNumber}" + " = " + (firstNumber / secondNumber));

            }

        }
    }
}
