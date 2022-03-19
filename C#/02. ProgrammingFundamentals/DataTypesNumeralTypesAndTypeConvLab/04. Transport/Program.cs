using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            var peopleNumber = int.Parse(Console.ReadLine());

            var capacity = 24;
            var courses = Math.Ceiling((double)peopleNumber / capacity);
            Console.WriteLine(courses);

        }
    }
}
