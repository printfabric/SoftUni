using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Camel_sBack
{
    class Program
    {
        static void Main(string[] args)
        {
            var newList = Console.ReadLine().Split(new[] { ' ' }).
            Select(int.Parse).ToList();
            var camelBack = int.Parse(Console.ReadLine());            
            var rounds = (newList.Count - camelBack) / 2;

            if(rounds == 0)
            {
                Console.Write("already stable: ");
            }
            else
            {
                Console.WriteLine("{0} rounds", rounds);
                Console.Write("remaining: ");
            }            
            for (int i = 0 + rounds; i < newList.Count - rounds; i++)
            {
                Console.Write(newList[i] + " ");
            }
        }
    }
}
