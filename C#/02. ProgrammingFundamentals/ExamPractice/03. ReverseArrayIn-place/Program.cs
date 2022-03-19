using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ReverseArrayIn_place
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(new[] { ' ' }).Select(int.Parse).ToList();

            for (int i = list.Count - 1; i >= 0; i--)
            {
                Console.Write(list[i] + " ");
            }
        }
    }
}
