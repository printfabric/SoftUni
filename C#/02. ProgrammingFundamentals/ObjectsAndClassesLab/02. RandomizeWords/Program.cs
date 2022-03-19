using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(new[] { ' ' }).ToList();
            var rnd = new Random();
            var result = list.OrderBy(item => rnd.Next());
            Console.WriteLine(string.Join("\n", result));


            //var words = Console.ReadLine().Split(' ');

            //for (int pos1 = 0; pos1 < words.Length; pos1++)
            //{
            //    int pos2 = rnd.Next(words.Length);
            //    var old = words[pos1];
            //    words[pos1] = words[pos2];
            //    words[pos2] = old; 
            //}

            //Console.WriteLine(string.Join("\n", words));
        }
    }
}
