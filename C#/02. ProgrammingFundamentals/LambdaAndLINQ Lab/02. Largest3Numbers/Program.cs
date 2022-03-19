using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numList = Console.ReadLine()
                .Split(new[] { ' ' })
                .Select(int.Parse)
                .ToList();
                        
                 var decrList = numList.OrderByDescending(x => x).Take(3);
                Console.WriteLine(string.Join(" ", decrList));
           
        }
    }
}
