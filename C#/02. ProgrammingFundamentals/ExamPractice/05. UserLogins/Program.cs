using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.UserLogins
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { "->" }
                ,StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var userLogin = new Dictionary<string, string>();

            while (input[0] != "login")
            {
                userLogin[input[0]] = input[1];

                input = Console.ReadLine()
                .Split(new[] { "->" }
                , StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            }

            while(input[0] != "end")
            {
                if(userLogin.ContainsKey(input[0]))
                {
                    if(userLogin[input[0]] == input[1])
                    {
                        Console.WriteLine(input[0] + ": logged in successfully");
                    }
                    else
                    {
                        Console.WriteLine(input[0] + ": login failed");
                    }
                }

                input = Console.ReadLine()
                .Split(new[] { "->" }
                , StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            }
        }
    }
}
