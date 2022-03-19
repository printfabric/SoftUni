using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneNumbersArr = Console.ReadLine()
                .Split(new[] { " " }
                , StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var phoneNamesArr = Console.ReadLine()
                .Split(new[] { " " }
                , StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var name = Console.ReadLine();

            while(name != "done")
            {
                for (int i = 0; i < phoneNamesArr.Length; i++)
                {
                    if(name == phoneNamesArr[i])
                    {
                        Console.WriteLine($"{name} -> {phoneNumbersArr[i]}");
                    }
                }

                name = Console.ReadLine();
            }

        }
    }
}
