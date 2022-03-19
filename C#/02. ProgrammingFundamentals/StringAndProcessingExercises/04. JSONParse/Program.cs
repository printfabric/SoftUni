using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.JSONParse
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int[] Grades { get; set; }

        public Student(string name, int age, int[] grades)
        {
            this.Name = name;
            this.Age = age;
            this.Grades = grades;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string input = Console.ReadLine();

            input = input.Substring(2, input.Length - 2 - 2);

            string[] tokens = input
                .Split(new string[] { "},{" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string token in tokens)
            {
                string[] properties = token
                    .Split(new string[] { ",age:", ",grades:" }
                    , StringSplitOptions.RemoveEmptyEntries);

                string name = properties[0].Substring(6, properties[0].Length - 6 - 1);
                string age = properties[1];
                string grades = properties[2].Substring(1, properties[2].Length - 1 - 1);

                if (grades == string.Empty)
                {
                    grades = "None";
                }

                Console.WriteLine("{0} : {1} -> {2}", name, age, grades);
            }

        }
    }
}
