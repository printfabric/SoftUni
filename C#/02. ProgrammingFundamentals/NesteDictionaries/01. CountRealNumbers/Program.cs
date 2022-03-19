using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentRecords = new Dictionary<string, List<double>>();

            var numberOfStudents = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfStudents; i++)
            {
                var grades = Console.ReadLine().Split(new[] {' '});

                var name = grades[0];
                var number = double.Parse(grades[1]);

                if (!studentRecords.ContainsKey(name))
                {
                    studentRecords.Add(name, new List<double>());
                }

                studentRecords[name].Add(number);
            }

            foreach (var item in studentRecords)
            {
                string name = item.Key;
                List<double> numbers = item.Value;
                double avg = item.Value.Average();

                Console.WriteLine("{0} -> {1} (avg: {2:f2})", name
                    , string.Join(" ", numbers.Select(g => string.Format("{0:F2}", g))), avg);

                //foreach (var grade in numbers)
                //{
                //    Console.Write("{0:F2} ", grade);
                //}

                //Console.WriteLine("(avg: {0:F2})", avg);
            }
        }
    }
}
