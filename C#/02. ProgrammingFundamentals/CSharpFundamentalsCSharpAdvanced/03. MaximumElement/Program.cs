using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MaximumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());

            var queries = new Stack<int>();

            for (int i = 0; i < N; i++)
            {
                var querie = Console.ReadLine()
                    .Split(new[] { ' ' }
                    , StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToList();

                if (querie[0] == 1)
                {
                    queries.Push(querie[1]);
                }
                else if (querie[0] == 2)
                {
                    queries.Pop();
                }
                else if (querie[0] == 3)
                {
                    Console.WriteLine(queries.Max());
                }
            }
        }
    }
}
