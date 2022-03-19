using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eiTui
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> grades = new Dictionary<string, List<int>>();

            AddGrade(grades, "Gosho", 5);
            AddGrade(grades, "Kiro", 6);
            AddGrade(grades, "Gosho", 2);
            AddGrade(grades, "Kiro", 2);



            //Console.WriteLine("Gosho grades: " + string.Join(" ", grades["Gosho"]));
            //Console.WriteLine("Kiro grades: " + string.Join(" ", grades["Kiro"]));

            PrintGrades(grades);



        }

        private static void PrintGrades(Dictionary<string, List<int>> grades)
        {
            foreach (var name in grades.Keys)
            {
                Console.WriteLine("grades of " + name + ":");

                foreach (var grade in grades[name])
                {
                    Console.WriteLine(" - " + grade);
                }
            }
        }

        public static void AddGrade(Dictionary<string, List<int>> grades, string name, int grade)
        {
            if (!grades.ContainsKey(name))
            {
                grades[name] = new List<int>();
            }
            grades[name].Add(grade);
        }
    }
}
