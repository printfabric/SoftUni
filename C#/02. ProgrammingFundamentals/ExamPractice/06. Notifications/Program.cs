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
            var N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                var result = Console.ReadLine();
                if(result == "success")
                {
                    var operation = Console.ReadLine();
                    var message = Console.ReadLine();
                    ShowSuccess(operation, message);
                }
                else if(result == "error")
                {
                    var operation = Console.ReadLine();
                    var code = int.Parse(Console.ReadLine());
                    var reason = string.Empty;
                    if(code > -1)
                    {
                         reason = "Invalid Client Data";
                    }
                    else
                    {
                        reason = "Internal System Failure";
                    }
                    ShowError(operation, code, reason);

                }

            }

        }
        static void ShowSuccess(string operation, string message)
        {
            Console.WriteLine($"Successfully executed {operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Message: {message}.");
        }
        static void ShowError(string operation, int code, string reason)
        {
            Console.WriteLine($"Error: Failed to execute {operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Error Code: {code}.");
            Console.WriteLine($"Reason: {reason}.");
        }

    }
}
