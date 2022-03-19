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
            var employeeAges = new Dictionary<string, int>();
            var employeeSalaries = new Dictionary<string, double>();
            var employeePositions = new Dictionary<string, string>();

            var tokens = Console.ReadLine()
                .Split(new[] { ' ', '-', '>' }
                , StringSplitOptions
                .RemoveEmptyEntries);

            while(tokens[0] != "filter")
            {
                string name = tokens[0];
                string value = tokens[1];

                int age;
                double salary;
                if(int.TryParse(value, out age))
                {
                    employeeAges[name] = age;
                }
                else if (double.TryParse(value, out salary))
                {
                    employeeSalaries[name] = salary; 
                }
                else
                {
                    employeePositions[name] = value;
                }

                tokens = Console.ReadLine()
              .Split(new[] { ' ', '-', '>' }
              , StringSplitOptions
              .RemoveEmptyEntries);


            }

            string condition = Console.ReadLine().ToLower();

            if (condition == "position")
            {
                foreach(var employee in employeePositions)
                {
                    Console.WriteLine($"Name: {employee.Key}");
                    Console.WriteLine($"Position: {employee.Value}");
                    Console.WriteLine(new string ('=', 20));
                }
            }
            else if (condition == "age")
            {
                foreach (var employee in employeeAges)
                {
                    Console.WriteLine($"Name: {employee.Key}");
                    Console.WriteLine($"Age: {employee.Value}");
                    Console.WriteLine(new string('=', 20));
                }
            }
            else if (condition == "salary")
            {
                foreach (var employee in employeeSalaries)
                {
                    Console.WriteLine($"Name: {employee.Key}");
                    Console.WriteLine($"Salary: {employee.Value:F2}");
                    Console.WriteLine(new string('=', 20));
                }
            }

        }
    }
}
