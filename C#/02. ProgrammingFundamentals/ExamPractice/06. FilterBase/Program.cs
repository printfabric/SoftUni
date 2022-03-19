using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FilterBase
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { "->" }
                ,StringSplitOptions.RemoveEmptyEntries)
                .ToList();

           // var newDict = new Dictionary<string, List<int>>();

            var dict = new Dictionary<string, string>();

            while(input[0] != "filter base")
            {
                dict[input[0]] = input[1];


                input = Console.ReadLine()
                .Split(new[] { "->" }
                , StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            }

            input = Console.ReadLine()
                .Split(new[] { "->" }
                , StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            if (input[0] == "Salary")
            {
                foreach (var person in dict)
                {
                    double ignoreMe;
                    bool successfullyParsed = double.TryParse(person.Value, out ignoreMe);
                    if (successfullyParsed)
                    {
                        Console.WriteLine("Name: " + person.Key);
                        Console.WriteLine("Salary: " + person.Value);
                        Console.WriteLine("====================");
                    }

                }
                
            }

              

            else if(input[0] == "Position")
            {
                foreach (var person in dict)
                {
                    double ignoreMe;
                    bool successfullyParsed = double.TryParse(person.Value, out ignoreMe);
                    if (!successfullyParsed)
                    {
                        Console.WriteLine("Name: " + person.Key);
                        Console.WriteLine("Salary: " + person.Value);
                        Console.WriteLine("====================");
                    }

                }
            }
        }
    }
}
