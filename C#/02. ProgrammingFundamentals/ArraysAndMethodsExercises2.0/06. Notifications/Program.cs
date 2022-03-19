using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Notifications
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var result = Console.ReadLine();

                if (result == "success")
                {
                    var operation = Console.ReadLine();
                    var message = Console.ReadLine();
                    ShowSuccess(operation, message);
                }
                else if (result == "error")
                {
                    var operation = Console.ReadLine();
                    var code = int.Parse(Console.ReadLine());
                    ShowError(operation, code);
                }
            }

        }

        static string ShowSuccess(string operation, string message)
        {            
            Console.WriteLine($"Successfully executed {operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Message: {message}.");
            return operation;
        }

        static string ShowError(string operation, int code)
        {            
            Console.WriteLine($"Error: Failed to execute {operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Error Code: {code}.");
            if (code > 0)
            {
                Console.WriteLine($"Reason: Invalid Client Data.");
            }
            else
            {
                Console.WriteLine($"Reason: Internal System Failure.");

            }
            return operation;
        }


    }
}
