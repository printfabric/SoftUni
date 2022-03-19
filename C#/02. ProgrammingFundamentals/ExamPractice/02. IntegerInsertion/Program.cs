using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IntegerInsertion
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine()
                .Split(new[] { ' ' })
                .Select(int.Parse)
                .ToList();

            var input = Console.ReadLine();


            while (input != "end")
            {
                var newInput = int.Parse(input);
                int i = Math.Abs(newInput);
                while (i >= 10)
                {
                    i /= 10;
                }

                list.Insert(i, newInput);
                input = Console.ReadLine();
            }

            
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
