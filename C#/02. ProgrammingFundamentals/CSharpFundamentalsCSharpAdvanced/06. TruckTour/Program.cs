using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var list = new List<int>();

            for (int i = 0; i < N; i++)
            {
                var input = Console.ReadLine()
                    .Split(new[] { ' ' }
                    , StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                if(input[0] >= input[1])
                {
                    list.Add(input[0]);
                }
                else
                {
                    list.Add(100000001);
                }
            }

            var oProp = list.Min();

            int index = list.FindIndex(a => a == oProp);

            Console.WriteLine(index);
        }
    }
}
