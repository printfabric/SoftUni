using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            var userCredential = new Dictionary<string, string>();

            var usernamePass = Console.ReadLine()
                .Split(new[] { ' ', '-', '>' }
                , StringSplitOptions
                .RemoveEmptyEntries)
                .ToList();
            var counter = 0;
            while (usernamePass[0] != "login")
            {
                userCredential[usernamePass[0]] = usernamePass[1];

                usernamePass = Console.ReadLine()
                .Split(new[] { ' ', '-', '>' }
                , StringSplitOptions
                .RemoveEmptyEntries)
                .ToList();
            }

            Console.WriteLine();
            usernamePass = Console.ReadLine()
                .Split(new[] { ' ', '-', '>' }
                , StringSplitOptions
                .RemoveEmptyEntries)
                .ToList();

            while (usernamePass[0] != "end")
            {
                var username = usernamePass[0];
                var pass = usernamePass[1];

                //foreach (var user in userCredential)
                //{
                if (userCredential.ContainsKey(username) && userCredential.ContainsValue(pass))
                {                    
                        Console.WriteLine($"{username}: logged in successfully");                    
                }
                else
                {
                    Console.WriteLine($"{username}: login failed");
                    counter++;
                }
                
                usernamePass = Console.ReadLine()
                .Split(new[] { ' ', '-', '>' }
                , StringSplitOptions
                .RemoveEmptyEntries)
                .ToList();
            }

            Console.WriteLine($"unsuccessful login attempts: {counter}");
        }
    }
}
