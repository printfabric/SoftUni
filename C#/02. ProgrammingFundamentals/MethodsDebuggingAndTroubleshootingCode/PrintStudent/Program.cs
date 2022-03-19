using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintStudent("Ivan", 24, 4);
            PrintStudent("Dragan");
        }

        static void PrintStudent(
            string name, int age = 18 , double grade = 6.00)
        {
            Console.WriteLine("Student: {0}, Age: {1}, Grade: {2}",
                name, age, grade);
        }
    }
}
