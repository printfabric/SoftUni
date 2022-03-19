using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.AverageStudentGrades
{
    class Program
    {
       

        static void Main(string[] args)
        {

            var numberOfStrudents = int.Parse(Console.ReadLine());

            var grades = new Dictionary<string, List<double>>();

            for (int i = 0; i < numberOfStrudents; i++)
            {
                var input = Console.ReadLine()
                .Split(new[] { ' ' }
                , StringSplitOptions.RemoveEmptyEntries)
                .ToList();
                var name = input[0];
                var grade = double.Parse(input[1]);

                AddGrade(grades, name, grade);
            }
            foreach (var name in grades.Keys)
            {
                Console.Write(name + " -> ");
                foreach (var grade in grades[name])
                {
                    Console.Write(string.Join(" ", $"{grade:f2} "));
                   // Console.WriteLine(average);
                }
                var average = grades[name].Average();
                Console.WriteLine($"(avg: {average:f2})");
            }
        }
        private static void AddGrade(Dictionary<string, List<double>> grades, string name, double grade)
        {
            if(!grades.ContainsKey(name))
            {
                grades[name] = new List<double>();
            }
            grades[name].Add(grade);
        }

     
    }
}





//foreach (var nameAndGrade in grades)
//{
//    var average = nameAndGrade.Value.Average();
//    var name = nameAndGrade.Key;
//    var grade = string.Join(" ", nameAndGrade.Value.Select(p => string.Format("{0:f2}", p)));
//    Console.Write(name + " -> " + "{0:f2}", grade);
//    Console.Write($" (avg: {average:f2})");
//    Console.WriteLine();
//}