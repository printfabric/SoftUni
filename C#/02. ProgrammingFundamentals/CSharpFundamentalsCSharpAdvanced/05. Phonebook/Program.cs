using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new Dictionary<string, string>();

            var input = Console.ReadLine().Split('-');

            while(input[0] != "search")
            {
                if(!phoneBook.ContainsKey(input[0]))
                {
                    phoneBook.Add(input[0], input[1]);
                }
                else
                {
                    phoneBook[input[0]] = input[1];
                }

                input = Console.ReadLine().Split('-');


            }
            Console.WriteLine();
            while(input[0] != "stop")
            {
                input = Console.ReadLine().Split('-');
                if(input[0] == "stop")
                {
                    break;
                }
                if(phoneBook.ContainsKey(input[0]))
                {
                    Console.WriteLine(input[0] + " -> " + phoneBook[input[0]]);
                }
                else
                {
                    Console.WriteLine("Contact {0} does not exist.", input[0]);
                }

            }
        }
    }
}
