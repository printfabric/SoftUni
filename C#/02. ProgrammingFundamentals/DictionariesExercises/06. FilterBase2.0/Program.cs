using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FilterBase2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var ageDict = new Dictionary<string, int>();
            var salaryDict = new Dictionary<string, double>();
            var positionDict = new Dictionary<string, string>();

            var input = Console.ReadLine()
                .Split(new[] { ' ', '-', '>' }
                , StringSplitOptions
                .RemoveEmptyEntries)
                .ToList();

            while(input[0] != "filter")
            {
                int age;
                double salary;
                string position = input[1];

                if (int.TryParse(input[1], out age))
                {
                    ageDict[input[0]] = age;
                }
                else if (double.TryParse(input[1], out salary))
                {
                    salaryDict[input[0]] = salary;
                }
                else 
                {
                    positionDict[input[0]] = position;
                }

                input = Console.ReadLine()
                .Split(new[] { ' ', '-', '>' }
                , StringSplitOptions
                .RemoveEmptyEntries)
                .ToList();
            }

            input = Console.ReadLine()
                .ToLower()
                .Split(new[] { ' ', '-', '>' }
                , StringSplitOptions
                .RemoveEmptyEntries)
                .ToList();

            if(input[0] == "age")
            {
                foreach (var kvp in ageDict)
                {
                    Console.WriteLine($"Name: {kvp.Key}");
                    Console.WriteLine($"Age: {kvp.Value}");
                    Console.WriteLine(new string('=', 20));
                }
            }
            else if (input[0] == "salary")
            {
                foreach (var kvp in salaryDict)
                {
                    Console.WriteLine($"Name: {kvp.Key}");
                    Console.WriteLine($"Salary: {kvp.Value:F2}");
                    Console.WriteLine(new string('=', 20));
                }
            }
            else 
            {
                foreach (var kvp in positionDict)
                {
                    Console.WriteLine($"Name: {kvp.Key}");
                    Console.WriteLine($"Position: {kvp.Value}");
                    Console.WriteLine(new string('=', 20));
                }
            }

        }
    }
}
